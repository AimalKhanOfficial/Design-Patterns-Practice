import AdapterPattenPackage.AverageMediaPlayer;
import AdapterPattenPackage.WindowsMediaPlayer;

public class Main {
    public static void main(String[] agrs){
        AverageMediaPlayer avg = new WindowsMediaPlayer();
        avg.playMelody("mp3", "Hello World");
    }
}
