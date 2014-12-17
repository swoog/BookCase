Feature: Count cutting board
	In order to avoid a bookcase
	As a user
	I want to count cutting wooden board

Scenario: Use one board.
	Given a wooden board of "400x400x15" mm
	And I want a wooden board of "400x400" mm
	When I count cut
	Then I have this 1 wooden board

Scenario: Use two board.
	Given a wooden board of "400x400x15" mm
	And I want a wooden board of "400x400" mm
	And I want a wooden board of "400x400" mm
	When I count cut
	Then I have this 2 wooden board

Scenario: Use two board patern and one board.
	Given a wooden board of "800x400x15" mm
	And I want a wooden board of "400x400" mm
	And I want a wooden board of "400x400" mm
	When I count cut
	Then I have this 1 wooden board

Scenario: Use two different board patern and one board.
	Given a wooden board of "600x400x15" mm
	And I want a wooden board of "400x400" mm
	And I want a wooden board of "200x400" mm
	When I count cut
	Then I have this 1 wooden board

Scenario: Use two different board patern and two board.
	Given a wooden board of "400x400x15" mm
	And I want a wooden board of "400x400" mm
	And I want a wooden board of "200x400" mm
	When I count cut
	Then I have this 2 wooden board