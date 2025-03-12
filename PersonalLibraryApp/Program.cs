using PersonalLibraryApp.Backend;

namespace PersonalLibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PopulateDummiData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());


        }

        private static void PopulateDummiData()
        {
            Library.AddNewBook("Despre Dumnezeu si om", "Lev Tolstoi", "Filozofie si Spiritualitate", 272, "9789735076603", "Unread");
            Library.AddNewBook("Neuroplasticitatea, Secretul longevitatii creierului", "Leon Danaila", "Sanatate", 280, "9786303051710", "Reading", 229);
            Library.AddNewBook("Fii obsedat sau fii mediocru", "Grant Cardone", "Dezvoltare Personala", 290, "9789975334921", "Read");
            Library.AddNewBook("Deep Work", "Cal Newport", "Dezvoltare Personala", 300, "978067223255", "Read");
            Library.AddNewBook("Cel mai intelept din incapere", "Tom Gilovich, Lee Ross", "Dezvoltare Personala", 336, "9786063335273", "Read");
            Library.AddNewBook("Arta Negocierii", "Chris Voss", "Leadership", 304, "6069456327", "Reading", 80);
            Library.AddNewBook("Jurnalul fericirii", "Nicolae Steinhardt", "Spiritualitate", 576, "9789734627370", "Unread");
            Library.AddNewBook("Manager 80/20", "Richard Koch", "Business", 287, "9786069135020", "Read");
            Library.AddNewBook("50 de idei pe care trebuie sa le cunosti - Fizica", "Jane Baker", "Stiinta", 203, "9786063323058", "Unread");
            Library.AddNewBook("Cel mai bogat om din Babilon", "George S. Clason", "Business", 143, "9789737780027", "Reading", 60);
            Library.AddNewBook("Secretele succesului", "Dale Carnegie", "Dezvoltare Personala", 279, "9789737780027", "Reading", 279);

        }


    }
}