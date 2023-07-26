# qa_automation
https://roadmap.sh/qa

This is a road map with resources that I think runs well when done parallel to the road map above

I say follow the linked road map up to the automation testing section. You should know your comfort level when reading through the various steps if you need to dive in deeper or not.

Once you hit automation jump here.

Once you finish here go back to the linked road map and fill in blanks where you feel it fits. You should already have enough to get a beginner lvl automation job.

I provide some learning resources in the road map. I stop after the beginning section. I think by that point it is important for you to start figuring out how to find resources. SDET is a forever changing field so learning will be forever. 

Skills:
1. Programming language
	1. c#, JS, Python
		1. All 3 are useful but pick one and stick with it. Mix in the other two when needed
		2. I think c# is one of the better languages to build automation with but JS works well too since most web apps are built using JS
		3. Python can serve all needs but I prefer it for more small internal tools and dashboards
	2. basic html, css, js
		1. just a general idea of how js interacts with a static page
	3. Xpath - https://www.w3schools.com/xml/xpath_intro.asp
2. Front end Frameworks - Start with first 2 under chosen language. Expand after.
	1. c#
		1. Selenium - https://testautomationu.applitools.com/learningpaths.html?id=csharp-web-ui-path
		2. Playwright - https://www.youtube.com/watch?v=5i53YLWD_QI&list=PL6tu16kXT9PoUv6HwexX5LPBzzv7QkI9W
	2. JS
		1. Selenium - https://testautomationu.applitools.com/learningpaths.html?id=javascript-web-ui-path
		2. Playwright - https://testautomationu.applitools.com/learningpaths.html?id=playwright-path
		3. Cypress - https://testautomationu.applitools.com/learningpaths.html?id=cypress-path
		4. webdriver.io - https://webdriver.io/docs/gettingstarted
	3. Python - https://testautomationu.applitools.com/learningpaths.html?id=python-testing-path
		1. Selenium
		2. Robot
3. Back end Testing
	1. Postman - https://www.youtube.com/watch?v=zp5Jh2FIpF0
	2. c#
		1. restsharp - https://www.youtube.com/watch?v=ZuRkmc_VcQM
	3. JS
		1. https://testautomationu.applitools.com/learningpaths.html?id=javascript-api-path
	4. Python
		1. Previous Python Course
4. Git, github, ci/cd
	1. need to be able to branch main, make test, submit for code review
	2. should be able to have a fake project that when updated triggers your tests on github actions
	3. might be good to expand on more tools and the cross over between automation and devops but do this later.
5. Explore Test Automation Patterns
	1. Page Object Model
	2. Screenplay - https://cucumber.io/blog/bdd/understanding-screenplay-(part-1)/
6. Test Data Management
	1. Learn strategies for managing test data effectively, including generating test data, using mock data, and handling data-driven tests.
7. Advanced Automation Concepts
	1. Parallel Testing
	2. Headless Testing
	3. Report Generation
	4. multiple browsers
		1. Selenium grid
		2. tools like Zalenium
	5. Utilizing docker 
	6. logging

Practice ideas:
1. Need to learn a specific web interactions(for example controlling drop downs)
	1. https://testpages.herokuapp.com/styled/index.html
2. Create a small test suite using one of these resources
	1. https://ultimateqa.com/dummy-automation-websites/
3. Compare the extra functionality that comes in playwrite to selenium. Build a selenium framework that has those functions
