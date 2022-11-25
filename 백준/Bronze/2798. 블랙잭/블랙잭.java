
import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner((System.in));
        int N=sc.nextInt();
        int M=sc.nextInt();

        int[] input = new int[N];

        for(int i=0; i<N;i++){
            input[i] = sc.nextInt();
        }
        long result = AllSearch(input,N,M);
        System.out.println(result);
    }

    static long AllSearch(int[] array, int N, int M){
        long result = 0;
        for(int i=0;i<N;i++){
            for(int j=i+1;j<N;j++){
                for(int k=j+1;k<N;k++){
                    int temp = array[i] +array[j]+array[k];
                    if(M==temp){
                        return temp;
                    }
                    if(result < temp&&temp <M){
                        result=temp;
                    }
                }
            }
        }
        return result;
    }
}