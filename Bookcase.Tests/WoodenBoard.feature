Feature: Wooden board
	In order to avoid a bookcase
	As a user
	I want to define a wooden board

Scenario: A wooden board
	Given a wooden board of "400x300x15" mm
	Then the width is 300 mm
	And the height is 400 mm
	And the thickness is 15 mm

Scenario: Another wooden board
	Given a wooden board of "300x400x15" mm
	Then the width is 300 mm
	And the height is 400 mm
	And the thickness is 15 mm

Scenario: A wooden board with the thickness in first
	Given a wooden board of "15x300x400" mm
	Then the width is 300 mm
	And the height is 400 mm
	And the thickness is 15 mm