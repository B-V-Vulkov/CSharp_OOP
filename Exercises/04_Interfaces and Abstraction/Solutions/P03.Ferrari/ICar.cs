namespace P03.Ferrari
{
    using System.Collections.Generic;

    public interface ICar
    {
        string Model { get; set; }

       string Driver { get; set; }

        string Brakes();

        string Gas();
    }
}
