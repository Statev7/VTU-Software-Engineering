namespace P022_Builder.Builder
{
    using P022_Builder.Models;

    public abstract class Builder
    {
        public House House { get; set; }

        public Builder()
        {
            this.House = new House();
        }

        public House Build() => this.House;

        public HouseBuilder Built => new HouseBuilder(this.House);
    }
}
