package AdapterPattenPackage;

public class WindowsMediaPlayer implements AverageMediaPlayer {

    public void playMelody(String formatType, String name) {
        if (formatType.equalsIgnoreCase("mp3")) {
            System.out.println(String.format("Playing %1$s.%2$s", name, formatType));
        } else {
            System.out.println("Unsupported format, can't play!");
        }
    }
}
