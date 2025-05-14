# Eedi API Task

## Assumptions:
* Have assumed data structure - not sure how all the data links with other data with the db
* Added Generic get only for answers and topics should more information be required by FE
* Have not implemented a POST search endpoint due to exposing an dedicated Improve endpoint
* Limited validation added for GET with Ids
* Test data static and not mocked with Bogus etc
* With more knowledge of how the FE consumes better endpoints can be made or more detailed models created.
* Omitted schema description due to time constraints.

## Improve API

* Summary List - Provides information to build a summary list of topics with child topics and their number of misconceptions.
```
GET /Improve

[
  {
    "misconceptionCount": 6,
    "id": 1,
    "name": "Number",
    "parentId": null
  },
  {
    "misconceptionCount": 5,
    "id": 2,
    "name": "Algebra",
    "parentId": null
  },
  {
    "misconceptionCount": 3,
    "id": 3,
    "name": "Fractions",
    "parentId": 1
  },
  {
    "misconceptionCount": 1,
    "id": 4,
    "name": "Decimals",
    "parentId": 1
  },
  {
    "misconceptionCount": 2,
    "id": 5,
    "name": "Factors",
    "parentId": 1
  },
  {
    "misconceptionCount": 1,
    "id": 6,
    "name": "Multiples",
    "parentId": 2
  },
  {
    "misconceptionCount": 2,
    "id": 7,
    "name": "Primes",
    "parentId": 2
  },
  {
    "misconceptionCount": 2,
    "id": 8,
    "name": "Fractions",
    "parentId": 2
  }
]

```

* List of misconceptions based on topic - allows user to view misconceptions per topic

```
GET /Improve/Misconceptions/{topicId}

[
  {
    "id": 1,
    "topicId": 4,
    "question": {
      "id": 0,
      "questionImg": "/answers/1.png",
      "answerImg": "/answers/1.png"
    },
    "answerUrl": "/answers/1.png",
    "isCorrect": false
  },
  {
    "id": 2,
    "topicId": 4,
    "question": {
      "id": 0,
      "questionImg": "/answers/2.png",
      "answerImg": "/answers/2.png"
    },
    "answerUrl": "/answers/2.png",
    "isCorrect": false
  },
  {
    "id": 3,
    "topicId": 4,
    "question": {
      "id": 0,
      "questionImg": "/answers/3.png",
      "answerImg": "/answers/3.png"
    },
    "answerUrl": "/answers/3.png",
    "isCorrect": false
  }
]

```