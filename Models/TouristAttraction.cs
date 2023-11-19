using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace IntroducingTheWondersOfTheWorld.Models
{
    public class TouristAttraction
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string MapUrl { get; set; }
    }

    public class TouristAttractionList
    {
        public List<TouristAttraction> Attractions { get; set; }

        public TouristAttractionList()
        {
            Attractions = new List<TouristAttraction>();
            FillAttractions();

        }
        private void FillAttractions()
        {
            TouristAttractionList attractionList = new TouristAttractionList();
            Attractions.Add(new TouristAttraction
            {
                Name = "Kutsal Aile Bazilikası",
                ImageUrl = "https://cdn.pixabay.com/photo/2014/11/30/20/46/sagrada-familia-552084__340.jpg",
                Description = "La Sagrada Familia (Kutsal Aile), İspanya'nın Barselona şehrinde bulunan ve modern mimarinin öncülerinden sayılan Antoni Gaudi'nin 1883 yılında devraldığı fakat 1926 yılında bir tramvayın altında kalarak ölmesi sonucu yarım kalan bir bazilikadır.",
                MapUrl = "https://goo.gl/maps/Wutsja8bARTxCVSX6"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Victoria Şelaleleri",
                ImageUrl = "https://cdn.pixabay.com/photo/2021/02/01/19/50/waterfalls-5971816__340.jpg",
                Description = "Viktorya Şelaleleri veya Mosi-oa-Tunya dünyanın en görkemli şelalelerindendir.Zambezi Nehrinin üzerinde, Zambiya ve Zimbabve sınırları arasında, bulunur.Şelaleler yaklaşık olarak 1,7 km genişliğinde ve 128 m yüksekliğindedirler.",
                MapUrl = "https://goo.gl/maps/BdscqnzmdUmQgB1z7"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Sümela Manastırı",
                ImageUrl = "https://media.istockphoto.com/id/486953630/tr/foto%C4%9Fraf/sumela-monastery.jpg?b=1&s=170667a&w=0&k=20&c=IupqPrOfJ_AaYe-t4XjUOYUR0wSAoD-78nx8qXcnox0=",
                Description = "Sümela Manastırı, Trabzon ilinin Maçka ilçesindeki Altındere vadisi sınırları içerisinde yer alan Meryem Ana Deresi'nin batı yamaçlarında yer alan, Kara tepesinin üzerinde ve deniz seviyesinden 1.150m yükseklikte konumlanmış Rum Ortodoks manastır ve kilise kompleksidir.",
                MapUrl = "https://goo.gl/maps/qfXeGomo6LXShYdQA"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Cehennem Kapısı",
                ImageUrl = "https://media.istockphoto.com/id/1074792972/tr/foto%C4%9Fraf/darvaza-gaz-krater-t%C3%BCrkmenistan-orta-asya-asya.jpg?s=612x612&w=0&k=20&c=HBIbOnlqQnU7Ob_oWxBkQ2p-1X8CbAgxJWgQEMKxqa8=",
                Description = "Cehennem Kapısı(Türkmence: Jähennem derwezesi) veya Derveze Çukuru,Türkmenistan'ın Ahal ilinin Derveze ilçesinde bir doğal gaz kuyusu. Karakum Çölü'nün ortasında, Derveze kasabasının yakınlarında bulunmaktadır.",
                MapUrl = "https://goo.gl/maps/HDw3YsenmEkf1xXJ9"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Lotus(Bahai) Tapınağı",
                ImageUrl = "https://listelist.com/wp-content/uploads/2017/06/1-Lotus-600x450.jpg",
                Description = "Nilüfer Tapınağı(Lotus Temple), Hindistan'ın Delhi kentinde 1986'da ibadete açılan ve açmak üzere olan bir nilüfer çiçeğinin taç yapraklarını taklit eden Bahá'í ibadethanesi",
                MapUrl = "https://goo.gl/maps/LAHvzJocfmKTaosN9"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Notre Dame Katedrali",
                ImageUrl = "https://listelist.com/wp-content/uploads/2017/06/5-Notre-Dame-600x338.jpg",
                Description = "Notre Dame Katedrali(Fransızca: Cathédrale Notre Dame de Paris) Paris, Fransa'da bulunan dünyaca ünlü bir katedraldir. Meryem Ana'ya ithafen isimlendirilmiştir.Gotik yapı Île de la Cité'nin doğu kısmında, Paris'in diğer tüm önemli yapıları gibi Seine Nehri'nin kıyısında bulunur.",
                MapUrl = "https://goo.gl/maps/nswdR298LTY6eKRFA"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Yellowstone Ulusal Parkı",
                ImageUrl = "https://cdn.pixabay.com/photo/2018/11/07/05/24/grand-prismatic-spring-3799785__340.jpg",
                Description = "Yellowstone Ulusal Parkı(Yellowstone National Park), ABD'nin Idaho, Montana ve Wyoming eyaletlerinde yer alan millî parkı. 1 Mart 1872'de Devlet Başkanı Ulysses S. Grant'ın imzasıyla ABD'nin ve dünyanın ilk ulusal parkı olmuştur..",
                MapUrl = "https://goo.gl/maps/4R3Xvhy6E2nn3buj6"
            });
            Attractions.Add(new TouristAttraction
            {
                Name = "Kabe",
                ImageUrl = "https://cdn.pixabay.com/photo/2015/11/19/07/20/mosque-1050478__340.jpg",
                Description = "Kâbe olarak anılan, İslam'ın en önemli camisi, Suudi Arabistan'ın Mekke kentindeki Mescid-i Haram'ın merkezinde yer alan bir yapıdır.İslam'ın en kutsal yeridir. Müslümanlar tarafından Beytullah (Allah'ın Evi) olarak isimlendirilir ve namaz ibadetinin yerine getirilmesinde Müslümanlar için kıbledir.",
                MapUrl = "https://goo.gl/maps/rgXm7fVDhLbknrF39"
            });
        }
    }
}
