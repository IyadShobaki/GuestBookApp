﻿using GuestBook;


// WelcomeMessage
GuestLogic.WelcomeMessage();

var (guests, totalGuests) = GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);

GuestLogic.DisplayGuestCount(totalGuests);