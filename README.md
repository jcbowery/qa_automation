# qa_automation

## Intro
https://roadmap.sh/qa

This is a road map with resources that I think runs well when done parallel to the road map above.

Follow the linked road map up to the automation testing section. You should know your comfort level when reading through the various steps if you need to dive in deeper or not.

Once you hit automation jump here.

## Prerequisites

-  **HTML, CSS** - <https://www.freecodecamp.org/learn/2022/responsive-web-design/>
	  Take the Responsive Web Design course on FreeCodeCamp. It goes above what you need, but it help to have a decent understanding. Don't worry about being able to build anything with it. Use <https://www.w3schools.com/> for reference when needed.

- **JS** - <https://www.w3schools.com/js/default.asp>
	  Follow the tutorial. After that skip to [JSHTMLDOM](https://www.w3schools.com/js/js_htmldom.asp). Again you are not trying to master this just know enough so that you can understand it. You should be able to do some basic html manipulation with js by the end of this. JS is still needed with some front end testing.

- **How the internet works** - <https://roadmap.sh/guides/what-is-internet>
		
- **What is an API** - <https://youtu.be/s7wmiS2mSXY?si=fvNjppthOyvouCW3>
		
- **What is REST** - <https://dev.to/cassiocappellari/fundamentals-of-rest-api-2nag>
		

- Pick a language (more will prob be needed as you go but gotta start somewhere)
	- **C#**
	- **Python**
	- **JS/TS**

You can't go wrong with any of these. If you are relying on the resources here I am using python so do with that aas you will.

## Frontend Web
Ok is e2e front end testing the most important form of testing? No. Is it the primary focus of automation on the whole? See previous answer. But we will start here because, and this is just my personal experience, majority of companies equate automation with front end web automation and this is a roadmap to get your foot in the door. 

1.  **Xpath** - <https://www.w3schools.com/xml/xpath_intro.asp>
		Not the most exciting thing to start with but since you already know css selectors like id and class might as well throw this one extra piece before jumping in. <https://devhints.io/xpath> is a good resource for reference. 
2. **UnitTesting Framework** - Choose according to language. Just because this is one of the best unit testing resources I've seen for any language, here is a bonus Python resource <https://pytest-with-eric.com/> 
3. **Front end Frameworks** - We will start Selenium.
	1. Start point- <https://www.selenium.dev/> Read through their official docs. It isn't the best but it certainly isn't the worst. It will give you a little more baseline before jumping into any of the other resources.
	2. *C#* - <https://testautomationu.applitools.com/learningpaths.html?id=csharp-web-ui-path>
	3. JS - <https://testautomationu.applitools.com/learningpaths.html?id=javascript-web-ui-path>
	4. Python - <https://www.youtube.com/watch?v=pcGqraAgMto&list=PLhW3qG5bs-L8vvw4HUrF9o4t6npvmbHWP>

You can skip these next two until after you wrap up some base line frontend, backend, perf, ect. I do think these newer tools are really good and worth knowing, but I still think getting selenium fundamentals will help with these for later. 

- *Playwright* - <https://testautomationu.applitools.com/learningpaths.html?id=playwright-path>
- *WebdriverIO* - <https://www.youtube.com/watch?v=gdd5ZC5L9TM&list=PLhW3qG5bs-L9K2xtu-04jZFqykzXzqJW8&index=1>

4. **OOP** - <https://www.youtube.com/watch?v=SiBw7os-_zI>
		This is a precursor to the POM. Follow this up with specifics in w/e language you are using.
5. **POM** - The official selenium documents do a decent job at covering patterns. I have some small examples of some patterns here as well <https://github.com/jcbowery/Automation_Patterns>. Just remember this isn't a fully implemented solution just getting pattern ideas through.

6. **Practice**
Use first two links for learning the tools and hwo to deal with specific elements and situations. Use the third for learning how to implement patterns or any other quick proof of concept. Use the last for full implementation practice. 
		- <http://www.uitestingplayground.com/> 
		- <http://the-internet.herokuapp.com/>
		- <https://www.saucedemo.com/>
		- <https://automationexercise.com/>

7. **Learn git, github, cicd** (just start with github actions)
		At this point you should be starting to look for resources on your own. I'll occasionally add something when I think it's worth, but it's time to build those problem solving skills.

8. should be able to have a fake project that when updated triggers your tests on github actions
		The fake project can just be a text document you edit and the tests to be triggered. Use your tests created in the practice link


At this point you have enough on you to start looking for entry lvl automation jobs. Please don't stop here just start applying from here. Start reading things like `https://medium.com/slalom-build/dont-automate-test-cases-58e3b959ce6`. This is all opinions so don't take this as gospel, but do start thinking about processes, why, how, ect.



## Backend
Ok at this point you should be taking suggestions and running with them so This won't be as built out. 

1. SQL - https://datalemur.com/
2. api testing tools in given language. 
3. Postman (It can be used for automation but...ewwwwwww). Still good for manual testing and figuring out an api before coding the tests. 
4. Start to think of the why's? 
		At this point you should be focusing less on HOW to do a thing and more of the why. If you are "API testing" and don't know more to the ask other than "test the thing", the how won't really matter. Once you have your purpose clear then dive into how to solve your issue. 

Practice resources for API:
- <https://petstore.swagger.io/>
- <https://automationexercise.com/>

## Performance
1. start with the list in <https://roadmap.sh/qa>
2. [decent locust starter](https://www.youtube.com/watch?v=q45WwSOC42Q&list=PLJ9A48W0kpRKMCzJARCObgJs3SinOewp5&index=1)

## Advanced Concepts
You can get a job without these but I still think they are important before being hired. They are definitely required for a non jr position. 

1. Parallel Testing

2. Headless Testing

3. Report Generation

4. cross browser

10. Selenium grid

11. Utilizing docker

12. Mobile

