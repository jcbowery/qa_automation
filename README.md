# qa_automation

https://roadmap.sh/qa

  

This is a road map with resources that I think runs well when done parallel to the road map above

  

I say follow the linked road map up to the automation testing section. You should know your comfort level when reading through the various steps if you need to dive in deeper or not.

  

Once you hit automation jump here.

  

Once you finish here go back to the linked road map and fill in blanks where you feel it fits. You should already have enough to get a beginner lvl automation job.

  

I provide some learning resources in the road map. I stop after the beginning section. I think by that point it is important for you to start figuring out how to find resources. SDET is a forever changing field so learning will be forever.

  

## Prerequisites

-  HTML, CSS - https://www.freecodecamp.org/learn/2022/responsive-web-design/
	  Take the Responsive Web Design course on freeCodeCamp. It goes above what you exactly need but it help to have a decent understanding. Don't worry about being able to build anything with it. Use https://www.w3schools.com/ for reference when needed.

- JS - https://www.w3schools.com/js/default.asp
	  Follow the tutorial after that skip to JS HTML DOM. Again you are not trying to master this just know enough so that you can understand it. You should be able to do some basic html manipulation with js by the end of this. JS is still needed with some front end testing.

- How the internet works - https://roadmap.sh/guides/what-is-internet
		If this is new to you go through it.
- What is an API - https://youtu.be/s7wmiS2mSXY?si=fvNjppthOyvouCW3
		Just watch it. 
- What is REST - https://dev.to/cassiocappellari/fundamentals-of-rest-api-2nag
		Just Read it.

- Pick a language (more will prob be needed as you go but gotta start somewhere)
	- C#
	- Python
	- JS/TS

		Here is where things really become a dealers choice. I'll give you my thoughts on it but just know EVERYONE has different opinions and there is no right or wrong answer here. Ok here we go. If all of this is new to you start with JS/TS. You already started JS and modern tools like WebdriverIO and Playwright will just fit right in. If you have some programming experience and you are picking up specifically for your current employer, pick up what they use. If you aren't sure if you really want to do automation and you could go some other tech route, go C# for swe and python for DevOPs or just making small tools. I'm not going to link any courses for any of these just use google. There are more beginner classes out there than there are atoms in the universe. 



## Frontend
Ok is e2e front end testing the most important form of testing? Hell no. Is it the primary focus of automation on the whole? See previous answer. But we will start here because, and this is just my personal experience, majority of companies equate automation with front end web automation. 

1.  Xpath - `https://www.w3schools.com/xml/xpath_intro.asp`
		Not the most exciting thing to start with but since you already know css selectors like id and class might as well throw this one extra piece before jumping in.` https://devhints.io/xpath` is a good resource for reference. 
2. UnitTesting Framework- Choose according to language. 
3. Front end Frameworks - If you went JS start WebdriverIO or Playwright. 
		- Playwright - `https://testautomationu.applitools.com/learningpaths.html?id=playwright-path`
		- WebdriverIO - `https://www.youtube.com/watch?v=gdd5ZC5L9TM&list=PLhW3qG5bs-L9K2xtu-04jZFqykzXzqJW8&index=1`
	- For the Selenium path (if not start here learn eventually)
		- C# - `https://testautomationu.applitools.com/learningpaths.html?id=csharp-web-ui-path`
		- JS - `https://testautomationu.applitools.com/learningpaths.html?id=javascript-web-ui-path`
		- Python - `https://www.youtube.com/watch?v=pcGqraAgMto&list=PLhW3qG5bs-L8vvw4HUrF9o4t6npvmbHWP`

4. OOP - `https://www.youtube.com/watch?v=SiBw7os-_zI`
		This is a precursor to the POM. Follow this up with specifics in w/e language you are using.
5. POM - https://martinfowler.com/bliki/PageObject.html and the pdf above (It's viewable online when routed through reddit but not other wise. Idk it's worth reading so shhhhh)
6. Practice
		Use the first two links for learning the in's an out's of your testing tool. Use the third for practicing implementing the POM.
		- `http://www.uitestingplayground.com/`
		- `http://the-internet.herokuapp.com/`
		- `https://www.saucedemo.com/`

7. Learn git, github, cicd (just start with github actions)
		At this point you should be starting to look for resources on your own. I'll occasionally add something when I think it's worth, but it's time to build those problem solving skills.

8. should be able to have a fake project that when updated triggers your tests on github actions
		The fake project can just be a text document you edit and the tests to be triggered.

At this point you have enough on you to start looking for entry lvl automation jobs. Please don't stop here just start applying from here. Start reading things like `https://medium.com/slalom-build/dont-automate-test-cases-58e3b959ce6`. This is all opinions so don;t take this as gospel, but do start thinking about processes, why, how, ect.

## Backend
Ok at this point you should be taking suggestions and running with them so This won't be as built out. 

1. SQL
	1. I will eventually update this with some dockerfiles and sql to get you spun up on some db's to play with.
2. api testing tools in given language. RestSharp for C# for example. 
3. Postman (It can be used for automation but...ewwwwwww). Still good for manual testing and figuring out an api before coding the tests. 
4. Start to think of the why's? 
		At this point you should be focusing less on HOW to do a thing and more of the why. If you are "API testing" and don't know more to the ask other than "test the thing", the how won't really matter. Once you have your purpose clear then dive into how to solve your issue. 

Practice resources for API:
- https://petstore.swagger.io/

## Performance
I'm not going to try and pretend that I have ever found a company that actually did this. At this point we are doing things in parallel. If that ever changes I'll update this with more insights but for now, GLHF. 

1. start with the list in `https://roadmap.sh/qa`
2. I've been going through `https://www.youtube.com/watch?v=q45WwSOC42Q&list=PLJ9A48W0kpRKMCzJARCObgJs3SinOewp5&index=1` for locust
3. `https://www.youtube.com/watch?v=3O3c2KKMxiM` is on my radar

## Advanced Frontend
You can get a job without these but they are good skills.

1. Parallel Testing

2. Headless Testing

3. Report Generation

4. cross browser

10. Selenium grid

11. Utilizing docker

12. Maybe screenplay pattern