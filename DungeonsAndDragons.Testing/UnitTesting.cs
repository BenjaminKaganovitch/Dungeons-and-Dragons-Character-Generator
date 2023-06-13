using DungeonsAndDragons.Domain;
using DungeonsAndDragons.DataAccess;
using DungeonsAndDragons.Services;
using Moq;
using Microsoft.EntityFrameworkCore;

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
            Mock<DbSet<Feature>> features = new();
            Mock<DbSet<Background>> backgrounds = new();

            context.Setup(c => c.Features).Returns(features.Object);

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
            
            backgrounds.Verify(b => b.Add(It.IsAny<Background>()), Times.Once);
            context.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod()]

        public void StatRollerTest()
        {
            Mock<ApplicationDbContext> context = new Mock<ApplicationDbContext>();
            Mock<DbSet<Feature>> features = new();
            Mock<DbSet<Background>> backgrounds = new();

            context.Setup(c => c.Features).Returns(features.Object);

            Repository repo = new(context.Object);
            //DataService service = new(repo);

            int roll = repo.GetStatRoll();

            Assert.IsTrue(roll >= 3 && roll <= 18);
        }
    }
}