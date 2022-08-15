# Learning and experiencing React

Some representations of components relations, when integrating React elements do .tsx and .html files; and, also, some relations between CSS classes and React components.

![ReactStudying drawio](https://user-images.githubusercontent.com/81485964/178539707-032b035d-59f7-4b7c-8c53-b0a93d5577c3.svg)

# [Tutorial: Intro to React](https://reactjs.org/tutorial/tutorial.html)

## Notes

### How to start a localhost:3000 with node:
```
/c/MyProjects/my_react_experimentations/tutorial-intro-to-react (main)
$ npm start
```

`components` = isolates pieces of code

```
> ... building blocks of React apps:
 - elements
 - components.
```
>React elements
>> `const element = <h1>Hello, world!</h1>;`
>> It is called `JSX`, and it is a syntax extension to JavaScript.
>>`JSX` produces React “elements”. 
>>React elements are objects.
>>You can think of them as descriptions of what you want to see on the screen.
>>React reads these objects and uses them to construct the DOM and keep it up to date.
>>Elements are the smallest building blocks of React apps.
>>React elements are immutable. Once you create an element, you can’t change its children or attributes. An element is like a single frame in a movie: it represents the >>UI at a certain point in time.

>React components

>>Conceptually, components are like JavaScript functions or JavaScript Classes.
>>They accept arbitrary inputs `(called “props”)` and return React elements describing what should appear on the screen.
>>We call such components “function components” because they are literally JavaScript functions.

>>You can also use an ES6 class to define a component.

>>So, we have: Function and Class components


#### `NOTE`: codeacademy = study JS there.
