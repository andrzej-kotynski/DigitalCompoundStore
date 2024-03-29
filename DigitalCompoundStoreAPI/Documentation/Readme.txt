﻿Video Games Store Inventory => Console Compound Store / Console Compound Store Inventory => Digital Compound Store / Digital Compound Store Inventory
Name change: https://blog.pragtechnologies.com/how-to-rename-an-asp-net-core-project/

About Store:
- brick and mortar stores with shipping capabilities,
- sells and buys physical copies of video games to and from customers,
- possible future expansions towards wider variety of products

Web app points:
- database stores all necessary information for performing sales of physical copies of video games,
- API allows the operation of Creating, Reading, Updating and Deleting data contained in the database,
- the body of code allows the expansion of business in the future by adding new entities and functionalities

Expansion of business:
- opening new stores,
- opening new warehouses,
- selling new variety of products

New variety of products:
- gaming systems,
- vaping accessories,
- LED lights,
- body odour inhibitors (game instead of shower!)

New functionalities:
- front-end for store staff,
- front-end for online customers - e-commerce style with basket,
- invoicing module,
- pop-up callendar for entering sell/buy date - also front-end probably

Useful stuff to check out:
- video game database with API https://www.igdb.com/
- another video game database https://www.mobygames.com/browse/games/full,1/


Thoughts about the code:

Why use enum instead of giving a user freedom to type a game system manually with a property /* public string Category {get; set;} */
- to decrease mistyping errors,
- to make filtering by gaming console more accurate - you don't have to take into account misspelling of the system's names


Database design questions:
- how to add timestamps for create, read, delete properties in each entity?