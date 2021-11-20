Injection Molding Cycle Time Estimator
By: Joshua Walles
Version 1.0.0
Copyright 2010
Intelligent Software

Thank you for downloading this open source product.  The purpose of this program is to take some of the guesswork out of 
quoting injection molded cycle times for the plastic industry.  This program, however, is only to be used as a guideline.
For a more detailed estimation, a Finite Element Analysis should be done with the parts specific geometry and proposed
gating method using a program like Autodesk's MoldFlow.  

As this in an open source project, I have included the source code with this installation.  Also included is an Excel file
called Plastic_Conductivities.xls.  This file contains the data used to calculate thermal diffusivities in in^2/hr for the
various plastics supported by the program.

The formulas used can be found in Plastic Part Design for Injection Molding; Malloy, Robert A.; Hanser Gardner Pubblications; 
C 1994; p. 86

The program assumes that the mold has optimal cooling which is generally reasonable if the mold is just being designed.
If the mold is a transfer tool, the cooling time may be significantly higher than the estimator's value based on
mold design inefficiencies.

Due to mechanical reliability issues, it was assumed that for any unscrewing action, a rack and pinion system would be
used instead of a motorized system.  The assumption was made that the maximum amount of time this action would take
to complete was 30 seconds.  If this needs to be adjusted to match your specific needs, you may do so in the file
Form1.cs on line 131 of the code.

The majority of the time in a molding cycle is taken up by cooling, however, to simulate a complete cycle, an adjustment
factor was introduced to cover mold closing, injection time, mold opening, and part ejection.  This covers the complete
cycle.  It was assumed that the total cycle time is equal to 1.5 times the cooling time.  If this needs to be adjusted to 
match your specific needs, you can find it in the file Form1.cs on lines 131 and 133 of the code.

I hope you enjoy this program as much as I did writing it.  I feel that it brings data from many sources together in one
place for convenient use by molders and engineers for both cycle development verification and cost estimation.  I have 
tried to make it easy to use and as light as possible.  If you have any comments, questions or suggestions for improvement, 
feel free to contact me at jswallesdaf@hotmail.com.

Joshua Walles
Project Engineer