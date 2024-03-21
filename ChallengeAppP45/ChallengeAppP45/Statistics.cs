namespace ChallengeAppP45
{
    public class Statistics // klasa - model danych, to po prostu klasa z odpowiednimi propercjami
    {
        public float Min { get; set; } // propercja (właściwość) jest mechanizmem umożliwiającym kontrolowany dostęp do pól klasy
        public float Max { get; set; }
        public float Average { get; set; }
        public char AverageLetter { get; set; }
    }
}