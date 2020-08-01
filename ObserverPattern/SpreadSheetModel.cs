using System;

namespace DesignPatternPractice.ObserverPattern
{
    public struct SpreadSheetModel
    {
        private string _content;
        private DateTime _createdDate;

        public SpreadSheetModel(string content, DateTime createdDate)
        {
            _content = content;
            _createdDate = createdDate;
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime CreateDate
        {
            get { return _createdDate; }
        }
    }
}