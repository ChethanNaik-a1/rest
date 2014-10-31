REST-API
========

This is a REST API example using ASP.NET Web API

Below are the example to test GET, POST and DELETE operations using Fiddler

﻿GET:
http://localhost:55570/api/employee
==========================================================
POST:
POST http://localhost:55570/api/employee HTTP/1.1
Host: localhost:55570
Connection: keep-alive
Content-Length: 42
Accept: */*
Origin: http://localhost:55570
X-Requested-With: XMLHttpRequest
User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/38.0.2125.111 Safari/537.36
Content-Type: application/json; charset=UTF-8
Accept-Encoding: gzip,deflate
Accept-Language: en-GB,en-US;q=0.8,en;q=0.6

{"Id":4,"Name":"Rishi Karmakar","Role":"Program Manager"}
==========================================================
DELETE:
DELETE http://localhost:55570/api/employee/1 HTTP/1.1
Host: localhost:55570
Connection: keep-alive
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8
User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/38.0.2125.111 Safari/537.36
Accept-Encoding: gzip,deflate,sdch
Accept-Language: en-GB,en-US;q=0.8,en;q=0.6
Content-Length: 0
