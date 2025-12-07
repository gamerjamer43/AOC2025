#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int dial = 50;
int hits = 0;

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
        // if left then step is -1
        char dir = line[0];

        // slice first char (inlcude null term i forgor)
        memmove(line, line + 1, strlen(line) + 1);

        // convert string to line (no invalid chars, base 10)
        value = strtol(line, NULL, 10);

        // step thru each step, not efficient but again it works
        for (int i = 0; i < value; i++) {
            // ternary cuz i giving up. there no reason for this to be called constantly
            dir == 'L' ? dial-- : dial++;

            // count wraps
            if (dial < 0) dial += 100;
            if (dial >= 100) dial -= 100;

            // count lands
            if (dial == 0) hits++;
        }
    }

    printf("Total hits of %d\n", hits);
}