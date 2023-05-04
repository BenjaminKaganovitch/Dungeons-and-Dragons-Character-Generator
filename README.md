# Dungeons-and-Dragons-Character-Generator

Summary:
The D&D character generator is a comprehensive website that enables users to create custom characters for use in Dungeons & Dragons games. The website begins by prompting users to either register for an account or log in to an existing one, which allows them to save and access their characters at any time. Authenticated users can also change their name and password, as well as recover a lost password if necessary.

The generator includes detailed documentation on the different lineages or races, backgrounds, classes, subclasses, spells, feats, and rules of the game, which users can access to learn more about the available options for their characters. Users can select a name for their character, choose a lineage or race, and pick an alignment from a list of options. They can then select a background, class, and subclass, each of which provides unique abilities, traits, and proficiencies.

Users can also choose to add new spells to their spell list, select specific skills to be proficient in, and add new items and money to their character's inventory. The generator allows users to level up their characters to up to a total of 20 levels, with the ability to choose to upgrade two of their stats once, one of their stats twice, or to take a feat instead. The generator also supports multiclassing, enabling users to take a level in a different class instead of their main one if they meet the requirements.

Users can save their completed characters to the database for use at a later time and edit them after their initial creation. If they wish, they can also delete their characters. The generator also provides users with options to choose where they pull their options from, including whether or not to use homebrew content.

The website features a clear and concise interface that makes it easy for users to navigate and interact with. It includes a landing page, a sign-up page, and a character creator that allows users to view and add attributes in a logical way. Users can also view the characters they have made and edit them as they wish, as well as access a wiki that provides information about different attributes and options without needing to create a character.

Finally, the generator allows users to create their own homebrew material, including feats, spells, backgrounds, lineages, subclasses, and classes, and submit it to administrators for review. Administrators can then moderate homebrew and approve it for addition to the main homebrew lists. Overall, the D&D character generator provides users with a comprehensive and customizable tool for creating unique and tailored characters for their Dungeons & Dragons games.


# <a name="_3d5hlgelrvnw"></a>Project
D&D Character Creator website

# <a name="_8ycbz1k7s8ap"></a>Basic requirements
- **Login / Register**: Users must be able to register an account and use it to log in.
- **Authenticated users** must be able to change their name and password.
- **Authenticated users** must be able to recover a lost password.
- **Roles**
  - **Administrators**: Administrators must be able to moderate homebrew, approving homebrew for addition to the main homebrew lists.
# <a name="_o091kil4wolh"></a>Character building requirements
- **Documentation**: Users should be able to view documentation on the following subjects:
  - **Lineages**: The ‘races’ available in the game to play as.
  - **Backgrounds**: Previous occupations or experiences for the character that shape who they are.
  - **Features**: The different abilities granted to the character as a result of their lineage, background, class, or subclass.
    - **Feats**: Optional features learned under specific conditions to give the character something they would otherwise not be able to use.
  - **Spells**: Magic that casting classes can use. They fall under many different categories based on the ‘school of magic’, components, and who can access it.
  - **Classes**: The different roles of characters, giving unique features to them based on whichever one they choose.
    - **Subclasses**: Extra subtypes of classes.
  - **Rules**: The rules of the game for how it plays.
    - **Proficiency bonuses**: Bonuses to certain skills and attack rolls for weapons the character has proficiency with. These increase as the characters level up.
- **Building**
  - **Name**: A user should be able to pick a name for their character.
  - **Lineage**: A user should be able to pick a lineage for their character.
  - **Alignment**: A user should be able to pick an alignment for their character from a list of alignments.
  - **Background**: A user should be able to pick a background for their character from a list of available backgrounds.
  - **Classes**: A user should be able to select a starting class for their character.
    - **Subclasses**: A user should be able to select a subclass for their character when they reach the appropriate level to do so.
  - **Spell List**: A user should be able to add new spells to their spell list if they have one.
  - **Feats**: Users should be able to add feats to their character.
  - **Inventory**: Users should be able to add new items and money to their characters’ inventories.
  - **Levels**
    - **Leveling up**: A user should be able to  level up your character to up to a total of 20 levels.
      - **Stat improvements**: A user should be able to choose to upgrade two of their stats once, one of their stats twice, or don’t upgrade and instead take a Feat of some kind.
    - **Multiclassing**: A user should be able to choose to take a level in a different class instead of their main one if they meet the requirements.
  - **Features**: Users should be able to add new features to their character.
  - **Skills**: Users should be able to select specific skills to be proficient in.
- **Saving**: Users should be able to save their completed characters to the database for use at a later time.
- **Editing**: Users should be able to edit their characters after their initial creation.
- **Deleting**: Users should be able to delete their characters if they wish.
- **Options**: Users should be able to choose where they pull their options from.
  - Users should be able to choose if they want to use homebrew content or not.
# <a name="_vw6fvsjrk7zd"></a>Design requirements.
- **Interface**: Users should be able to interact with the website in a clear and concise way
  - **Landing page**: Users should be able to navigate to their chosen destination with ease
  - **SignUp page**: Users should be able to sign up for or log into their account with ease
  - **Character creator**: Users should be able to view and add attributes in a logical way
  - **Character navigation and viewing**: Users should be  able to view the characters they have made and edit them as they wish
  - **Wiki**: Users should be able to view attributes and read about them without needing to create a character
  - **Homebrew creator**: Users should be able to create their own classes and attributes in a user friendly way
  - **Character Visual Generator**: Upon the creation of a character; the generator will file specfic data into "WALLIE" API Key that will then be converted into an image.
# <a name="_aee6mk46h3kk"></a>Homebrew requirements
- **Creation**: Users should be able to create new homebrew material in the following categories:
  - Feats
  - Spells
  - Backgrounds
  - Lineages
  - Subclasses
  - Classes
- **Submission**: Users should be able to submit their homebrew content to the administrators for review.

Note: This is the second repo
