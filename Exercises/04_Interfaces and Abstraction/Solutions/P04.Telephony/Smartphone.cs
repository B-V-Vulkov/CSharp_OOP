namespace P04.Telephony
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Smartphone : IBrowsable, ICallable
    {
        public List<string> Sites { get; }
        public List<string> Numbers { get; }

        public Smartphone()
        {
            this.Sites = new List<string>();
            this.Numbers = new List<string>();
        }

        public void AddSite(string site)
        {
            if (site.Any(char.IsNumber))
            {
                this.Sites.Add("Invalid URL!");
            }
            else
            {
                this.Sites.Add($"Browsing: {site}!");
            }
        }

        public void AddNumber(string number)
        {
            if (!number.All(char.IsDigit))
            {
                this.Numbers.Add("Invalid number!");
            }
            else
            {
                this.Numbers.Add($"Calling... {number}");
            }
        }

        public string Browsing()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var site in this.Sites)
            {
                stringBuilder.AppendLine(site);
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string Call()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var number in this.Numbers)
            {
                stringBuilder.AppendLine(number);
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
