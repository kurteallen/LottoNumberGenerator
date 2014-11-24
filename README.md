LottoNumberGenerator
Overview

Generates random numbers for four popular Canadian Lotteries or general 6/49 lotteries.

The project was written on Visual Studio Ultimate 2012 (written in C# on .NET 4.5). Using the MVC pattern (model-view-controller). In this implementation the controller, listens for events. It then sends a request to the model. The model returns the necessary information back to the controller which in turn updates the view. The controller knows about both the view and controller. However the model has not knowledge of the view and the view has no knowledge of the model.

This is the beginning of a project that will eventually be available on the android platform. The first version (1.0.0) only creates random lottery numbers for Pick4, LottoMax, Lotto649, Lottario and Encore.
Instructions

The user interface has 5 buttons. Four buttons show the lottey. Once any button is activated a fifth button named Encore will appear in the results. Pressing this button will generate a 7 digit encore number.
Install


Any requests or questions can be directed to info@kurtthedeveloper.com
