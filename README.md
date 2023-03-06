### Features

- Add medicine products to MDF database;
- Search medicine products via Name, Manufacture or Price;
- Split information by warehouses (similar to a WMS)
- 

# Pharmaceutics Backoffice

Simple backoffice application for pharma gestions. Developed while I was learning C#, .NET .

GUI elements are imported from the tutorial that I followed.
The panels, the searches and the logic are developed by me.




```flow
st=>start: Login
op=>operation: Login operation
cond=>condition: Successful Yes or No?
opp=>operation: Dashboard
op2=>operation: Add/delete/update pharma item
op3=>operation: Search by multiple filters

st->op->opp->op2->op3

```


