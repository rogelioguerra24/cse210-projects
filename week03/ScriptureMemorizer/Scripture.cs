using System.IO;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); // ✅ Ensure it's initialized

        string[] wordsArray = text.Split(' ');

        //Console.WriteLine(string.Join(", ", wordsArray));  // ✅ Print words correctly

        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word)); // ✅ Add words to the list
        }
    }
    public void HideRandomWords (int numberToHide) {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count); // Get a random index

            if (!_words[index].IsHidden()) // Only hide if not already hidden
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText() {
        string wordsText = string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {wordsText}";
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
