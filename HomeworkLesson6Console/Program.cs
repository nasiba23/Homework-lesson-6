using System;

namespace HomeworkLesson6
{
    class Program
    {
        static void Main(string[] args)
        {      
            assignment1();
            assignment2();
        }
        static void assignment1()
        {
            Console.Write("Enter pro or exp key here: ");
            string key = Console.ReadLine();
            string proKey = "ynPtHzhKq9gvuB9p";
            string expKey = "hgrmnh7t5k7zKuwK";
            DocumentWorker docWorker = new DocumentWorker();

            if (key.Equals(proKey))
            {
                docWorker = new ProDocumentWorker();
            }
            else if (key.Equals(expKey))
            {
                docWorker = new ExpertDocumentWorker();
            }
        }
        static void assignment2()
        {
            IPlayable player1 = new Player();
            IRecordable player2 = new Player();
            player2.Stop();
        }
    }
    //classes for the 1st assignment
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    //classes and interfaces for the 2nd assignment
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();   
    }
    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Music is playing");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Music is paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Music is stopped");
        }
        void IRecordable.Record()
        {
            Console.WriteLine("Recording");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Recording is paused");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is stopped");
        }
    }
}
