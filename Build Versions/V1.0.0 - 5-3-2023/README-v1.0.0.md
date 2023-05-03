# LaundroDrop-Orders
Laundro Drop - Laundromat Drop Off Order Tracking App

# Version v1.0.0
Source Code - Backup of code for this Version
Build-EXE - .exe file for running app (Note: This may be empty!)

# Features - v1.0.0
Create Orders
    -Select Customer for Order
    -Order Notes/Instructions
    -Items
        *Comforters - Twin/Full/Queen/King
        *Blankets - Twin/Full/Queen/King
        *Rugs - Small/Large
        *Sleeping Bags - Single/Double
        *Pillows
        *Horse Blankets
    -Total Display

Customer Selection / Edit / Add
    -Search for Customer
        *Customer ID
        *Name
        *Phone#
        *Email
        -Display Results in Data Grid View
    -Add Customer
        *Name Input
        *Phone# Input
        *Email Input
        *Address Input
        *IsCommercial Input
        *Customer Instructions Input
    -Edit Customer
        *Name Input (Can not Edit After Customer Created)
        *Phone# Input
        *Email Input
        *Address Input
        *IsCommercial Input
        *Customer Instructions Input
    -Confirm Customer Selection

Order Search / Edit / View Info
    -Search Order
        *Order#
        *Current Customer / Customer ID
        *Displayed in Data Grid View for user to select
    -View Order Info
        *Order Instructions
        *Customer Info
    -Update Order Status
        *Is Paid
        *Is Picked Up
    -Print Order Tickets
        *Basket Ticket
        *Customer Ticket
        *Employee Ticket
    -Delete Order

Admin Screen
    -Password Required
    -Price Change Screen
        *Displays all items in data grid view
            -Select and change value confirm with CONFIRM Button

Help Button
    -Display the Steps to Using Each Screen in Message Box

Validating Button Clicks/Input Fields - Messages
    -Message Box's will show if there is a Error or Warning
        -Order Lookup Screen
            *Delete Order Button -- Shows warning with yes or no to verify that user wants to delete order
            *Mark Order Button -- Shows warning if removing the picked up status due to pickup date being removed
            *Every Button Checks to see if there is a order selected if no order selected displays Warning Message
        -Order Create Screen
            *Warning message for if no customer is selected and if no items are Being added to order on Create Order Button Press
        -Customer Selection
            *Adding customer checks to see if Name and Phone# fields are not Empty because they are required -- if empty message box displaying Message
            *on Search if no customer found displays red text telling no customer found