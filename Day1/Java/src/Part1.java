import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class Part1 {
    private static int dial = 50;
    private static int turnsToZero = 0;

    public static void main(String[] args) throws IOException {
        String path = "C:\\Users\\fuzio\\Downloads\\AOC2025\\Day1\\code.txt";

        try (BufferedReader br = new BufferedReader(new FileReader(path))) {
            String line;

            while ((line = br.readLine()) != null) {
                // if left then mult by -1
                int value = Integer.parseInt(line.substring(1));
                if (line.startsWith("L")) value *= -1;

                // normalize
                dial += value;
                dial %= 100;

                // if hit zero add
                if (dial % 100 == 0) turnsToZero++;
            }
        }

        System.out.println("Hits at 0: " + turnsToZero);
    }
}