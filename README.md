# Building

## Task 

Design a class and object structure for a building. 

The building should have 2 floors (ground floor, first floor). On the ground floor there is an office space, a bookable meeting room and a technical room. On the upper floor there are bookable guest rooms (1 double and one single room). 

The functionality "Bookable" should only be mapped via a simple Boolean variable, which then indicates whether a room is free or occupied. No calendar-based booking solution or the like is to be implemented. 

As a function, let's consider lighting as an example. Each room has a main light that can be switched on and off. The meeting room has an additional lighting circuit. 

Other room functions such as air conditioning, shading, heating, etc. are not needed in the first implementation. However, expandability should be considered. 

If the light is switched in a room, a corresponding console output (simple) shall be done and the light property shall be switched accordingly.   

Create the above building as an object in a C# console application. 

After that, the light is to be "switched on" in the entire building. 

Now create a second building - the annex of the "hotel". This has 5 floors with 10 double rooms, 5 single rooms and a technical room. 

Switch on the light in all rooms there, too. 


## Expectation 

The application is compilable and implemented in good style. 
After running the application, the console outputs for the light switching operations appear. 
Extensibility and modeling of new building structures should be possible later. 
 

