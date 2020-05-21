using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Metodi
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestLunghezzasensibile() //lunghezzasensibile
        {

            long lenght = 3901;
            long lunghezza = ClasseBioInformatica.Metodi.LunghezzaSensibile();
            Assert.AreEqual(lenght,lunghezza);
        }
        [TestMethod]
        public void TestLunghezzaresistente()//lunghezzaresistente
        {

            long lenght = 3901;
            long lunghezza = ClasseBioInformatica.Metodi.LunghezzaResistente();
            Assert.AreEqual(lenght, lunghezza);
        }
        [TestMethod]
        public void TestCaratterediverso()//Carartterediverso
        {

            long lenght = 1603;
            long lunghezza = ClasseBioInformatica.Metodi.CarattereDiverso();
            Assert.AreEqual(lenght, lunghezza);
        }
        [TestMethod]
        public void TestPozioneUguale()//PorzioneUguale
        {

            string Uguale ="CGGGTATTTGAGGAATGCGCCGTCCTGCGCTATTGTTGGACGTTGCGCTGGCTACTTCCTGCCCACCTCACCCGCCACTTGACACCGTGGTCTTAGTCTGAGCCCAGTTTGCGGCTCAGCGGTTTAGTTGCGTGCGTGAGATCCGGACAGATCGTTCGCCGGCCGAAACCGACAAAATTATCGCGGTTGACAGGCCCGTGGGCACCGCTCCTATAATGGCTCTCGTTGGTCGCATGAAGTGCAGGAGGGATGCATCTTGGCAGATTCCCGCCAGAGCAAAACAGCCGCTAGTCCTAGTCCGAGTCGCCCGCAAAGTTCCTCGAATAACTCCGTACCCGGAGCGCCAAACCGGGTCTCCTTCGCTAAGCTGCGCGAACCACTTGAGGTTCCGGGACTCCTTGACGTCCAGACCGATTCGTTCGAGTGGCTGATCGGTTCGCCGCGCTGGCGCGAATCCGCCGCCGAGCGGGGTGATGTCAACCCAGTGGGTGGCCTGGAAGAGGTGCTCTACGAGCTGTCTCCGATCGAGGACTTCTCCGGGTCGATGTCGTTGTCGTTCTCTGACCCTCGTTTCGACGATGTCAAGGCACCCGTCGACGAGTGCAAAGACAAGGACATGACGTACGCGGCTCCACTGTTCGTCACCGCCGAGTTCATCAACAACAACACCGGTGAGATCAAGAGTCAGACGGTGTTCATGGGTGACTTCCCGATGATGACCGAGAAGGGCACGTTCATCATCAACGGGACCGAGCGTGTGGTGGTCAGCCAGCTGGTGCGGTCGCCCGGGGTGTACTTCGACGAGACCATTGACAAGTCCACCGACAAGACGCTGCACAGCGTCAAGGTGATCCCGAGCCGCGGCGCGTGGCTCGAGTTTGACGTCGACAAGCGCGACACCGTCGGCGTGCGCATCGACCGCAAACGCCGGCAACCGGTCACCGTGCTGCTCAAGGCGCTGGGCTGGACCAGCGAGCAGATTGTCGAGCGGTTCGGGTTCTCCGAGATCATGCGATCGACGCTGGAGAAGGACAACACCGTCGGCACCGACGAGGCGCTGTTGGACATCTACCGCAAGCTGCGTCCGGGCGAGCCCCCGACCAAAGAGTCAGCGCAGACGCTGTTGGAAAACTTGTTCTTCAAGGAGAAGCGCTACGACCTGGCCCGCGTCGGTCGCTATAAGGTCAACAAGAAGCTCGGGCTGCATGTCGGCGAGCCCATCACGTCGTCGACGCTGACCGAAGAAGACGTCGTGGCCACCATCGAATATCTGGTCCGCTTGCACGAGGGTCAGACCACGATGACCGTTCCGGGCGGCGTCGAGGTGCCGGTGGAAACCGACGACATCGACCACTTCGGCAACCGCCGCCTGCGTACGGTCGGCGAGCTGATCCAAAACCAGATCCGGGTCGGCATGTCGCGGATGGAGCGGGTGGTCCGGGAGCGGATGACCACCCAGGACGTGGAGGCGATCACACCGCAGACGTTGATCAACATCCGGCCGGTGGTCGCCGCGATCAAGGAGTTCTTCGGCACCAGCCAGCTGAGCCAATTCATGGACCAGAACAACCCGCTGTCGGGGTTGACCCACAAGCGCCGACTG";
            string lunghezza = ClasseBioInformatica.Metodi.PorzioneUguale();
            Assert.AreEqual(Uguale, lunghezza);
        }
        [TestMethod]
        public void TestCaratteriDifferenti()//Numero caratteri differenti
        {

            int differenze = 1;
            int codice = ClasseBioInformatica.Metodi.DifferenzeStringhe();
            Assert.AreEqual(differenze, codice);
        }

    }
}
    