Feature: PizzaPurchasing
	A simple website is for purchasing a pizza.

@PizzaPurchasing
Scenario: Select pizza and purchase it.
	Given launch joe's pizza website
	And select pizza
	And Click on Cart Icon
	Then Order Checkout page should be displayed 
	Then change the quantity in Checkout page
	And Click on Checkout button
	Then Order Confirmation page should be displayed