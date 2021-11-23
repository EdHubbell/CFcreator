using System.Collections.Specialized;

namespace XferPrintLib.Configuration
{
    public class XferPrintRecipeValidationErrors
    {
        public StringCollection XmlErrors { get; set; }
        private StringCollection _objectErrors;
        private StringCollection _toolBlockFilesMissing;

        public void AddError(string error)
        {
            if (_objectErrors == null)
            {
                _objectErrors = new StringCollection();
            }

            _objectErrors.Add(error);
        }

        public StringCollection GetObjectErrors()
        {
            return _objectErrors;
        }

        public void AddMissingToolblock(string error)
        {
            if (_toolBlockFilesMissing == null)
            {
                _toolBlockFilesMissing = new StringCollection();
            }

            _toolBlockFilesMissing.Add(error);
        }

        public StringCollection GetMissingToolblocks()
        {
            return _toolBlockFilesMissing;
        }
    }
}