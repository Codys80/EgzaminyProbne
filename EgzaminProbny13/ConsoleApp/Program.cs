namespace EgzaminProbny13ConsoleApp
{
    internal class Program
    {
        public static int checkAlbumsCount()
        {
            int albumsCount = 1;
            StreamReader sr = new StreamReader("E:\\Foldery\\dokumenty\\GitHub\\EgzaminProbny13ConsoleApp\\data.txt");
            while (!sr.EndOfStream)
            {
                sr.ReadLine(); albumsCount++;
            }
            return albumsCount = albumsCount / 6;
        }
        class DataStructure
        {
            string artist, album;
            int songsNumber, year, downloadNumber;
            public DataStructure(int index)
            {
                load(index);
            }
            public void load(int index)
            {
                index *= 6;
                StreamReader sr = new StreamReader("E:\\Foldery\\dokumenty\\GitHub\\EgzaminProbny13ConsoleApp\\data.txt");
                for (int i = 0; i < index; i++)
                {
                    sr.ReadLine();
                }
                    this.artist = sr.ReadLine();
                    this.album = sr.ReadLine();
                    this.songsNumber = Convert.ToInt32(sr.ReadLine());
                    this.year = Convert.ToInt32(sr.ReadLine());
                    this.downloadNumber = Convert.ToInt32(sr.ReadLine());
                sr.Close();
            }
            public void display()
            {
                Console.WriteLine("Artysta: " + this.artist);
                Console.WriteLine("Album: " + this.album);
                Console.WriteLine("Liczba utworów: " + this.songsNumber.ToString());
                Console.WriteLine("Rok wydania: " + this.year.ToString());
                Console.WriteLine("Wyświetlenia: " + this.downloadNumber.ToString());
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            List<DataStructure> Albumy = new List<DataStructure>();
            for(int i = 0; i < checkAlbumsCount(); i++)
            {
                DataStructure album = new DataStructure(i);
                Albumy.Add(album);
            }
            foreach (DataStructure album in Albumy) { album.display(); }
        }
    }
}
