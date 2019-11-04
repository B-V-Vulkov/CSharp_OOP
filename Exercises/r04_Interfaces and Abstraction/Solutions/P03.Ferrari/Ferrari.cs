namespace P03.Ferrari
{
    using System.Collections.Generic;
    using System.Text;

    class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; set; }
        public string Driver { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.Append(this.Model);
            st.Append("/");
            st.Append(this.Brakes());
            st.Append("/");
            st.Append(this.Gas());
            st.Append("/");
            st.Append(this.Driver);

            return st.ToString();
        }
    }
}
