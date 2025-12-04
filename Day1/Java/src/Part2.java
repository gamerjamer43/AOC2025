import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class Part2 {
    private static int dial = 50;
    private static int passes = 0;

    public static void main(String[] args) throws IOException {
        String path = "C:\\Users\\fuzio\\Downloads\\AOC2025\\Day1\\code.txt";

        try (BufferedReader br = new BufferedReader(new FileReader(path))) {
            String line;

            while ((line = br.readLine()) != null) {
                // i get a window made of glass, he gets a window made of glass
                // i get a step, he gets a step. i buy new clock radio. he cannot afford
                // great success
                int step = line.startsWith("L") ? -1 : 1;
                int degrees = Integer.parseInt(line.substring(1));

                // step thru each step, not efficient but again it works
                for (int i = 0; i < degrees; i++) {
                    dial += step;

                    // count wraps
                    if (dial < 0) dial += 100;
                    if (dial >= 100) dial -= 100;

                    // cound lands
                    if (dial == 0) passes++;
                }
            }

            System.out.println("Total passes of 0: " + passes);
        }
    }
}