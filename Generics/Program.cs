namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Content <int> content=new Content<int>();
            content.Value = 1;

            Content <string> strContent=new Content<string>();
            strContent.Value = "Uesli";

            Box <string> value = new Box<string>("InitialValue");
            value.UpdateValue("O shofer Te Keqen Motra se Jam e fejuar o");
            value.GetValue();

            MultipleGenerics<int, string> Tagers = new MultipleGenerics<int,string>(1, "Uesli");
            Console.WriteLine($"{Tagers.FirstVal},{Tagers.SecondVal}");

            Logger log = new Logger();

            log.Log<int>(12);
            log.Log<string>("Uesli");

            //Constraints<Box> content = new Constraints<Box>();

            Products<Item> product = new Products<Item>();
            var itm = new Item();
            product.addItems(itm);

            Console.WriteLine($"{content.Value},Name:{strContent.Value}");
            Console.ReadLine();
        }


        class Item : IProducts
        {
            public int id { get; }
        }


    }
}
