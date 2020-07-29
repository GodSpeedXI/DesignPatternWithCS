namespace DesignPatternPractice.MementoPattern
{
    /// <summary>
    /// Memento is a design pattern used to handle undo mechanism the content.
    /// This class is designed as Memento
    /// </summary>
    public class DocumentState
    {
        private readonly string _content;
        private readonly string _fontName;
        private readonly int _fontSize;
        public DocumentState(string content, string fontName, int fontSize)
        {
            _content = content;
            _fontName = fontName;
            _fontSize = fontSize;
        }
        public string GetContent()
        {
            return _content;
        }
        public string GetFontName()
        {
            return _fontName;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }
    }
}
