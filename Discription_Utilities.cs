/* 
    1- Load Company Data 
      Detect foe every bill that belows to which category "Electricity / Water / Gas"
   
    2- IsBillPaid
       Check if paid 3 different bills "Electricity / Water / Gas" stop loop immediately 
       Check if category code = Electricity and paid one bill Before continue by next row
       Check if category code = Water and paid one bill Before continue by next row
       Check if category code = Gas and paid one bill Before continue by next row

    3- Reload the current page
       Reload Current URL to avoid any Conflicts happen between bill to another

    4- Navigate to ussdFrame
       Navigate to ussdFrame to use any functions within UssdTransactionStepDef

    5- Generate Bill Payment Ussd Code
       Generate Bill Payment Ussd Code for current category   

    6- Put msisdn {string} in ussd page
      Enter msisdn for starting scenario on opencode URL

    7- Put shortcode {string} in ussd page
      Enter shortcode for starting scenario on opencode URL

    8- Press on send button in ussd page with msisdn {string} and shortcode {string}
      Click on "Send" button after enter msisdn and shortcode

    9- Put options {string} in ussd
      Enter options that need for every step :-
      @ Check checkAvailableBalanceOptions before start scenario
      @ Check checkAvailableBalanceOptions after end scenario 
      @ Using to calculate amount before and after transaction

    10- Generate Confirmation Bill Payment Ussd Code  
      Generate Confirmation Bill Payment Ussd Code

    11- Save initial balance before transaction
      Store Intial balance before any transaction   

    12- Save balance after transaction
      Store balance after any transaction

    13- Fetch initial balance before transaction
      Get inital balance that it starting before transaction 

    14- Fetch balance after transaction
      Get inital balance that it starting before transaction 

    15- Compute deducted amount from wallet balance
      Calculate deducted amount from wallet balance

    16- Fetch transaction amount
      Get Transaction amount


