# Xamarin Android Library Resource.Designer Fix

This library is to demonstrate how to avoid causing Resource.designer.cs issues for developers who use your library.

## What is Resource.designer.cs?

This is explained by Xamarin [here](https://developer.xamarin.com/guides/android/application_fundamentals/resources_in_android/part_1_-_android_resource_basics/). Basically it stores pointers to all your app's Android resources. What you may not realize is that it also stores that same information from *your app's dependencies*!

## So what's the problem? Why does this happen?

The problem arises when your app's and one of your app's dependencies have different versions of an Android dependency.

Let that sink in for a moment...regardless of what actual breaking changes there were or what a nuget package *should* support you can have compile issues when building your app. 

Now luckily this doesn't happen 100% of the time.  If the 2 versions of this dependency have no differences in their Resource.designer.cs file, you will be fine. Secondly if this dependency is smart enough not include a Resource.designer.cs or just include an empty one, you will also be fine (not all projects can do this).
