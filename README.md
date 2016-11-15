MONSTER MAKER
AUTHOR: Omnigamer
FIRST RELEASE: 11/15/16


DESCRIPTION:

Monster Maker is a basic viewer for creating discs corresponding to specific monsters in Monster Rancher (PS1). It can also just be used to view theoretical stats of monsters.



USAGE:

Select the primary type and the stat seeds that correspond to your desired monster.

Click Browse or manually enter a path and filename. Do not add an extension to your filename.

When ready, click "Make Monster!" and a .cue and .bin will be created in your specified directory.


TECH DETAILS:

Most of the data is hard-coded into the main file for simplicity.

Primary monster type is decided by the total minutes of the disc and the number of tracks it has. An in-game table is used to determine what monster type you get; I have simplified it for now so that it conforms to a constant ToC and makes a disc of the correct size.

Two stat seeds determine the overall stats of the monster. The first is derived from the disc seconds. The second is determined from the seconds in the first track, or the starting position of the 2nd track. The second stat seed also determines the subtype of the monster.

To work with this, I generate an empty .bin file corresponding to the required minutes and seconds for the selected primary type and first stat seed. The second stat seed is written into a corresponding .cue file. This should generate a ToC and blank "image" that you can burn to a disc and generate your desired monster.


CONTACT:

If you have any questions, contact me at @TheOmnigamer.
