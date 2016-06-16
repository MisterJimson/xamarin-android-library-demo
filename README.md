# Xamarin Android Library Resource.Designer Fix

This library is to demonstrate how to avoid causing Resource.designer.cs issues for developers who use your library.

## What is Resource.designer.cs?

This is explained by Xamarin [here](https://developer.xamarin.com/guides/android/application_fundamentals/resources_in_android/part_1_-_android_resource_basics/). Basically it stores pointers to all your app's Android resources. What you may not realize is that it also stores that same information from *your app's dependencies*!
