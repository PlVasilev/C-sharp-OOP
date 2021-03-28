using FestivalManager.Core.Controllers;
using FestivalManager.Core.Controllers.Contracts;
using FestivalManager.Entities;
using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Instruments;
using FestivalManager.Entities.Sets;
// Del upper for Judje
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SetControllerTests
    {
        [Test]
        public void Test()
        {
            IStage stage = new Stage();
            ISetController setController = new SetController(stage);

            IPerformer perfomer = new Performer("Pesho", 12);
            stage.AddPerformer(perfomer);

            ISong song = new Song("Killshot", new TimeSpan(0, 0, 3, 55));
            stage.AddSong(song);

            ISet set = new Long("Set1");
            set.AddPerformer(perfomer);
            set.AddSong(song);
            stage.AddSet(set);

            string result = setController.PerformSets();

            Assert.AreEqual("1. Set1:\r\n-- Did not perform", result);
        }

        [Test]
        public void Test2()
        {
            IStage stage = new Stage();

            ISet set = new Short("Set1");
            IPerformer perfomer = new Performer("Ivan", 20);
            perfomer.AddInstrument(new Guitar());
            set.AddPerformer(perfomer);

            set.AddSong(new Song("Song1", new TimeSpan(0, 0, 1, 2)));

            stage.AddSet(set);
            ISetController setController = new SetController(stage);

            string actualResult = setController.PerformSets();

            Assert.That(actualResult, Is.EqualTo("1. Set1:\r\n-- 1. Song1 (01:02)\r\n-- Set Successful"));
        }

        [Test]
        public void Test3()
        {
            IStage stage = new Stage();

            ISet set = new Short("Set1");
            IPerformer perfomer = new Performer("Ivan", 20);
            IInstrument instument = new Guitar();
            perfomer.AddInstrument(instument);
            set.AddPerformer(perfomer);

            set.AddSong(new Song("Song1", new TimeSpan(0, 0, 1, 2)));

            stage.AddSet(set);
            ISetController setController = new SetController(stage);

            var beforeValue = instument.Wear;
            setController.PerformSets();

            var afterValue = instument.Wear;

            Assert.That(beforeValue, Is.Not.EqualTo(afterValue));
        }

        [Test]
        public void Test4()
        {
            Stage stage = new Stage();
            Set set = new Medium("Set1");
            Performer performer = new Performer("Gosho", 24);
            Drums drums = new Drums();
            performer.AddInstrument(drums);
            Performer performer2 = new Performer("Pesho", 19);
            performer2.AddInstrument(new Guitar());
            set.AddPerformer(performer);
            set.AddPerformer(performer2);
            Song song = new Song("Song1", new TimeSpan(0, 1, 2));
            set.AddSong(song);
            Set set2 = new Medium("Long");
            stage.AddSet(set);
            stage.AddSet(set2);
            SetController setController = new SetController(stage);

            var befforValue = drums.Wear;

            string actual = setController.PerformSets();

            var aftervalue = drums.Wear;

            string expected = "1. Set1:\r\n-- 1. Song1 (01:02)\r\n-- Set Successful\r\n2. Long:\r\n-- Did not perform";

            Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(befforValue, aftervalue);

        }

    }
}