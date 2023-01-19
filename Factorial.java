import java.util.Scanner;

public class Factorial {
    public static void main(String[] args) {
        int num, factorial = 1;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a number: ");
        num = scanner.nextInt();
        scanner.close();
        for(int i = 1; i <= num; i++) {
            factorial = factorial * i;
        }
        System.out.println("The factorial of " + num + " is " + factorial);
    }
}
