namespace DesignPatternPractice.MementoPattern
{
    /// <summary>
    /// Memento is a design pattern used to handle undo mechanism the content.
    /// This class is designed as Originator
    /// </summary>
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public void SetContent(string content, string fontName, int fontSize = 9)
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

        public DocumentState CreateState()
        {
            return new DocumentState(_content, _fontName, _fontSize);
        }

        public void Restore(DocumentState state)
        {
            _content = state.GetContent();
            _fontName = state.GetFontName();
            _fontSize = state.GetFontSize();
        }
    }
}
