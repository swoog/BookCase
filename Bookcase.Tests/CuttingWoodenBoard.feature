Feature: Cutting Wooden Board
	In order to avoid a bookcase
	As a user
	I want to cut wooden board

Scenario: Cutting wooden board
	Given a wooden board of "400x400x15" mm
	And I want a wooden board of "400x400" mm
	When I cut
	Then I have this wooden boards :
	| Wooden board |
	| 400x400x15   |

Scenario: Cutting wooden board from 400x800
	Given a wooden board of "400x800x15" mm
	And I want a wooden board of "400x400" mm
	When I cut
	Then I have this wooden boards :
	| Wooden board |
	| 400x400x15, 400x400x15  |

Scenario: Cutting wooden board from 800x800
	Given a wooden board of "800x800x15" mm
	And I want a wooden board of "400x400" mm
	When I cut
	Then I have this wooden boards :
	| Wooden board |
	| 400x400x15,400x800x15,400x400x15   |

Scenario: Cutting wooden board from 600x800
	Given a wooden board of "600x800x15" mm
	And I want a wooden board of "400x400" mm
	When I cut
	Then I have this wooden boards :
	| Wooden board                     |
	| 400x400x15,200x800x15,400x400x15 |
	| 400x400x15,400x600x15,200x400x15 |


Scenario: Cutting wooden board from 600x800 with rectangular surface
	Given a wooden board of "600x800x15" mm
	And I want a wooden board of "200x400" mm
	When I cut
	Then I have this wooden boards :
	| Wooden board            |
	| 200x400x15,400x600x15,200x800x15 |
	| 200x400x15,200x200x15,600x600x15 |
	| 200x400x15,200x400x15,400x800x15 |
	| 200x400x15,400x400x15,400x600x15 |