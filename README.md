# Jeopardy
## Description
This was the final project for my C# II class. This project displays a splash form when it first loads. Users can select up to three players for the game and enter 
the players' names. Validation is used to ensure that each player has a name. 

This project also uses an XML file to pull in questions and answers for the game. The Deserialize method of the XMLSerializer class is used to read in the values from the XML file.

The players' names and scores are displayed at the bottom of the game board. When a square/dollar value is selected on the game board, users are given the answer. Then they select which player is answering, enter the question, and then select if their 
response was correct or not. After returning to the game board, the selected square is empty and no longer active.

The game ends when all squares have been selected, causing the game results form to appear. The winner and their score appears, along with the other players' scores. The game data
(the players' names and their final scores and the winner and the winner's final score) are sent to the database. The results form also queries the database and displays game data
for all past games, as well.

## Testing Information

1.	Run the application.
2.	Verify that the splash screen appears and then moves to the left, diminishes, and then goes away.
3.	Verify that the OptionsForm appears with a drop-down list to select the number of players.
4.	Verify that the Number of Players list has numbers 1, 2, and 3.
5.	Verify that only one text box initially appears to enter the Player 1 Name.
6.	Do not select the number of players, and then click GO.
7.	Verify that you receive an error message, and then click OK.
8.	Select two players, and then verify that a second text box appears for the name.
9.	Select three players, and then verify that a third text box appears.
10.	Do not enter any names, and then click GO.
11.	Verify that you receive an error message and can’t proceed.
12.	Enter all names, and then click GO.
13.	Verify that the OptionsForm window goes away and that the GameBoardForm appears with categories at the top and the dollar amounts filled in.
14.	Verify that a question mark (?) button appears in the top-right of the screen, and then select it.
15.	Verify that a message box appears and displays the rules of the game, and then click OK.
16.	Verify that the Players’ names all appear at the bottom of the screen.
17.	Select a dollar amount.
18.	Verify that the AandQForm appears and displays the answer.
19.	Verify that a drop-down list appears with all the correct players’ names, along with a text box to enter the question.
20.	Do not select which player is answering, and then click Submit.
21.	Verify that you receive an error message, and then click OK.
22.	Select who’s answering, but leave the text box blank, and then click Submit.
23.	Verify that you receive an error message, and then click OK.
24.	Enter a response in the text box, and then click Submit.
25.	Verify that you receive a message box asking if the response was correct.
26.	Click Yes.
27.	Verify that the AandQForm goes away and you are returned to the GameBoardForm.
28.	Verify that the correct player’s score was updated by the right amount on the bottom of the screen.
29.	Verify that the dollar amount box you selected is now empty and that nothing happens when you select it.
30.	Repeat steps 14-22.
31.	Click No for the correct answer.
32.	Verify that the correct player’s score is now the correct negative number.
33.	Play the game until all boxes are empty.
34.	Verify that the GameBoardForm goes away and that the ResultsForm appears.
35.	Verify that the correct player is displayed as the winner with their score.
36.	Verify that the other players and their scores also appear.
37.	Verify that a table appears and displays all past game scores.
38.	Click New Game.
39.	Verify that the ResultsForm goes away and the OptionsForm appears.
40.	Start playing the game, and verify that the game has correctly reset.
