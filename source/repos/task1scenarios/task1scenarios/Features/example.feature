Feature: AboutPlugin

Scenario: Verify option to hearing aid compatibility
   Given I launch the plugin app
   And I scroll Down and launch plugin 'AboutPlugin'
   Then verify 'HearingAidCompatibilityLink' is 'displayed' on 'AboutPluginPage'

 Scenario: Verify option to user guides
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
        Then verify 'UserGuidesLink' is 'displayed' on 'AboutPluginPage'
Scenario: Verify BodyText in Help section in app
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
        Then verify 'HelpSectionInAppBody' is 'displayed' on 'AboutPluginPage'
Scenario: Verify the AboutPlugin plugin is closed with Back button
        Given I launch the plugin app
        And I scroll Down and launch plugin 'AboutPlugin'
        Then verify 'back' is 'displayed' on 'HeaderPage'
        And verify 'close' is 'not Displayed' on 'HeaderPage'
        And verify 'header' is 'displayed' on 'HeaderPage'
        When I press 'back' on 'HeaderPage'
        Then verify 'MenuPageHeader' is 'displayed' on 'HeaderPage'