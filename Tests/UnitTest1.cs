namespace Tests
{
    public class Tests
    {
             
      
        [Test]
        public void StringCompearing()
        {
            string Month1 = "September";
            string Month2 = "September";

            Assert.AreEqual(Month1, Month2 );
        }

        [Test]
        public void ListCompearing()
        {
            var Fall = new List<string> { "September", "October", "November" };
            var Autumn = new List<string> { "September", "October", "November" };

            Assert.AreEqual(Fall, Autumn);

        }

        [Test]
        public void ElementFromListCompearing()
        {       
            string stroka1 = "September";
            var Fall = new List<string> { "September", "October", "November" };

            Assert.Contains(stroka1, Fall);
        }

        [Test]
        public void ABCompearing()
        {
            int a = 10;
            int b = 5;

            Assert.True(a > b);
        }

    }
}