# StatesVisited
A lightweight GUI application based on C# and Windows Forms that keeps track of which states a user has visited

### What is this project?
StatesVisited is a minimalistic, user-friendly application to keep track of which states you visit. It was created in June of 2019 as a personal project and was uploaded to GitHub in June of 2020.

StatesVisited currently supports the following features:
* Full GUI for intuitive, user-friendly use
* Add states and District of Columbia (Washington D.C) that have been visited and the year of the first visit
	* A table is automatically managed
		* The table by default is ordered alphabetically with D.C at the top
		* Click the header of a column to reorganize it by that column
		* Right-click a state to remove it or edit the year
	* Two separate percentages of states that have been visited are automatically calculated
		* One percentage includes Washington D.C (out of 51)
		* The other percentage represents the states only (out of 50)
	* The year with the most new states visited is also calculated automatically
* Import and Export Data
	* Export data as:
	  * StatesVisited (.SVisit) File
	    * This type of file is intended to backup data or share data between different machines running this application
	  * CSV File
	    * Exports the data as a CSV file to be used with other applications
		* Creates a column for each location that has been visited and another for the year
	* Import data from:
	  * StatesVisited (.SVisit) File
* Most features offer keyboard shortcuts:
	* Add Visited State (Ctrl+N)
	* Update (Ctrl+R)
	* Import (Ctrl+O)
	* Export as
		* SVisit (CTRL+S)
		* CSV (ALT+S)
	* Quit Application (CTRL+Q)
  
Much functionality of the application can be seen in the screenshots below:

![Main Window](Screenshots/MainWindow.PNG)

*Main Window (By default states will be alphabetized with District of Columbia at the top)*

![Add State](Screenshots/AddState.PNG)

*Adding a State (Uses autofill for user convenience)*

![Edit](Screenshots/Edit.PNG)

*Right-clicking a cell in the table opens the edit menu*

### How Can I Download and Install This Project?
As of right now, there is no installer. I may add one in the future, but for the time being, this is a Visual Studio 2019 Project. Therefore, the best way to run and install the project is to open the project file (the .sln file) in Visual Studio and compile it.

### How is This Project Licensed?
States Visited is licenced under GNU GPL 3.0.

### References
* The icon for this application was derived from: https://upload.wikimedia.org/wikipedia/commons/8/88/United-states_flag_icon_round.svg
