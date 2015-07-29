namespace ExpressProfiler
{
    public class Token
    {
        private readonly YukonLexer.TokenKind _kind;
        private readonly string _token;

        public Token(YukonLexer.TokenKind kind, string token)
        {
            _kind = kind;
            _token = token;
        }

        public YukonLexer.TokenKind Kind
        {
            get { return _kind; }
        }

        public string Text
        {
            get { return _token; }
        }
    }
}
