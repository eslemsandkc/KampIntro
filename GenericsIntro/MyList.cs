namespace GenericsIntro
{
    class MyList<T> // T hangi tipte çağırılcaksa o tipe göre dönüşür
    {
        T[] items;
        //constructor - ctor yazıp tabtab
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //item eleman demek istediğini yazabilirsin oraya fark etmez
        {
            T[] tempArray = items; // elemanlar kaybolmasın diye geçici olarak dizi 
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
