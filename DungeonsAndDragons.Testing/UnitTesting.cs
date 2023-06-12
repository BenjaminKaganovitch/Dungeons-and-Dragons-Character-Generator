using DungeonsAndDragons.Domain;
using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Services;
using Moq;

namespace DungeonsAndDragons.Testing
{
    [TestClass()]
    public class UnitTesting
    {
        [TestMethod()]
        public void GetLevelTest()
        {
            Class @class = new Class();
            Class class2 = new Class();

            Character character = new Character();
            character.Classes.Add(new() { Class = @class, Character = character, Level = 1});
            character.Classes.Add(new() { Class = @class2, Character = character, Level = 1});

            Assert.AreEqual(2, character.TotalLevels());
        }

        [TestMethod()]
        public void AddHomebrewBackgroundTest()
        {
            Mock<ApplicationDbContext> context = new Mock<ApplicationDbContext>();
            Repository repo = new(context.Object);
            DataService service = new(repo);

            BackgroundCreatingModel backgroundModel = new()
            {
                Name = "Salvager",
                Description = "You salvage things.",
                FeatureNames = new string[]
                {
                    "Salvager Code",
                    "Guild Connections"
                },
                FeatureDescriptions = new string[]
                {
                    "You know the seven rules of the Salvager Code.",
                    "Your job gives you a 50% discount to any travels that you embark on."
                }
            };
            
            
            service.CreateHomebrewBackground(backgroundModel, "AAA");
            
            Assert.AreEqual(1, service.GetHomebrewBackgrounds());
        }
    }
}