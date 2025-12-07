#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// dial starts at 50, turns starts at zero
int dial = 50;
int zero_turns = 0;

int main(int argc, char* argv[]) {
    // if no code file womp womp
    if (argc < 2) {
        printf("Supply a code file.");
        return 0;
    }

    // your filepath
    FILE *code = fopen(argv[1], "r");

    // line buffer
    char line[8];

    // value storage
    long int value = 0;

    // if invalid
    if (!code) {
        printf("Invalid path.");
        return 0;
    }

    while (fgets(line, sizeof(line), code) != NULL) {
        // if left then mult by -1
        char dir = line[0];

        // slice first char
        memmove(line, line + 1, strlen(line) + 1);

        // convert string to line (no invalid chars, base 10)
        value = strtol(line, NULL, 10);
        if (dir == 'L') value *= -1;

        // normalize
        dial += value;
        dial %= 100;

        // if hit zero add
        if (dial % 100 == 0) zero_turns++;
    }

    printf("Hits at 0: %d", zero_turns);
}