# FairShareMVC

FairShare Application Documentation

1. Idea Description

   The FairShare application allows users to share their expenses within groups, tracking each shared       expense and calculating the amounts owed between group members. Users can:

   Create groups and add members.

   Add transactions categorized (e.g., entertainment, transport, food).

   Specify who made the expense and who will contribute.

   Track all payments and receive detailed expense statistics.

   View the history of payments.

2. Use Case Description: "Transaction History Display"

   The user can view a detailed history of their transactions.
   
   Actors: User (Client), Group Members
   
   Main Flows:
   
      The user logs into the application (after creating or joining a group and making transactions).
      
      The user selects the MyHistory tab from the menu.
      
      The user views the transaction history for each group they belong to.
      
      The user can retrieve information from each payment, such as transaction dates, and payment details.
      
   Alternative Flows
   
      If the user has not created a group or no transactions are available, a relevant message appears.

3. How to Run the Application (Setup) 
   
   Install dependencies:   dotnet restore
   
   Start the application:  dotnet run / F5 (VS code)
   
   Access: The user can open the application in their local environment via a browser (e.g.,       http://localhost:5279).

4. Why the userId is Always Displayed as 1
   In the current implementation, the application displays the userId of 1 by default, as set directly in the Layout.cshtml file. This happens because of the following line (30) in the 
   Layout.cshtml:
   
      <a class="nav-link text-white" asp-area="" asp-controller="History" asp-action="UserHistory" asp-route-id="1">MY HISTORY</a>
   This asp-route-id="1" line in the Layout.cshtml hardcodes the userId as 1, so each time a user clicks on the MyHistory tab, the payment history is shown for the user with userId 1.
   
   The asp-route-id is used to pass the userId to the controller action. Since it's hardcoded in the Layout.cshtml file, the same userId is passed every time.
   To display the transaction history for different users, you can modify the asp-route-id dynamically in the Layout.cshtml file.

For example, if you want to display the payment history for the logged-in user, you should replace the hardcoded 1 with a variable that holds the current user's userId.
In a fully implemented system, after the user logs in, the userId would be stored in the session. 

5. Database Connection String
   Ensure that the DB_CONNECTION environment variable is set before running the application. In PaymentModel.cs, replace the environment variable reference with the actual connection string provided via email.
