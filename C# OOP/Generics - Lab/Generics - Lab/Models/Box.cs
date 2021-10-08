namespace BoxOfT.Models
{

    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        List<T> result;

        public Box()
        {
            result = new List<T>();
        }

        public void Add(T element)
        {
            result.Add(element);
        }

        public void Remove()
        {
            var itemToRemove = result[result.Count - 1];

            result.Remove(itemToRemove);

        }

        public override string ToString()
        {
            string res = string.Join(" ", result);

            return res.ToString(); 
        }
    }
}
