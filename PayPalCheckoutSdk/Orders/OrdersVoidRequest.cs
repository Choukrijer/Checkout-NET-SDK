// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// OrdersVoidRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type request
// @data H4sIAAAAAAAC/+x97W4cOZLg/3sKQrNAt/bqoy1/zKyBAVaW1d2a8YfOknuw8A6qWJlRVVwxyWySqVL1Yn/sA9yD3N97hd17rwODZH6nJNul6nabPwyrSCYZQQaDEcGI4L8fvKEZHDw/kCoFpSfXkqUHo4OXoBPFcsOkOHh+8JNkqSZUEGw0IostOXs5ORgd/K8C1PacKpqBAaUPnn/4++jgR6ApqEbpvx9cbnM7ijaKidXB6OAnqhhdcPCjn9PtOeXjE85AmPFrMDSlho7PLCx/he09WjUhPhgdHCtFt27Y70YH74CmbwXfHjxfUq7BFvxcMAVpWXCuZA7KMNAHz0XB+X+M7gu17Qq0GYC2UduE8nINRIO6BkW0kQo0uYKtJkupyJOnJKVbPdkTIgqWoJrQh6IuyDlWKUgD8Ap0LoUGUuRSEF0kCWi9LDhJZJZzsJ8SuSRmDUS52ZiQnygvgDD9/F+L7757nBQc/wf3i7P6r0Sm7i9QYAol/pwxwTLqvkimVfWE1GbUtdWEEt+8AtNIInPDMvYLWBCzQrCEIpQLMBsAgaAen5+RhHIOilCRYpHrekKOu30ykfAiBY3t2nCztAPrqNNIG2oK3WmIg/94fHn69viCcCau9MS3ac7SHXOmIFegQRhE9L5T5xfQrpuWhUrsH/V+Rh5vJlaIeFIoBcIQiwtUa+6+7Yd7GpZ+F6T+99HB91JlbZZ0Ts364xgScroZa+7o3t1w9jLgid+QzZola0tilpV+1P41qhjAyfMQ14kttEWO8FxZic9bC0MXnbvRcMCnYCjjn8127p7fZA3JlSzMLKfbDISZMWFAmAacZVEXWldlZxmYWYMiCc1NoYD47gjLMkgZNcC3RCpCC7OWyu53WjaxbDacaYQuDSj/d6IAiXtPzBeHg5lhGTTQb5Z35yC1Www5E8vAbkTy4UwYUAJMs85imlHz92/XxuT6+XRqpOR6wsAsJ1KtpmuT8alaJo8fP/6nP2hI7Bjjp5NnhxNyAYkU9uxXjnVbXC2FcyBLRbEl5UTXWsncFfrNvuAyufq5kAbqe14bJcXKlbyRBvwhMK2XI0NSsCo4VQRuLNfRlkXnSl4zy2hXBUupSIAsCkNSCZoIaYiCf4PEEMo5YeKacpbiZJRMsw3Qbtc4UZAyM1syQUXCxGoml8u+/TjYrrH8/U16KMHtWkIXsjDIinK6BTXWwCExkBLXFyn7ItjX7nb5mdCGco7b6qUDposzqxrN0rJRfbv31feIH4gbzS0hQEpqn5VbO+dU7J6XvZYCtl28AgdLi+b+bZZ38XBnZbLFfUozWQSeFNaJcmIUFdrts5EVrNaE2mN5QTlSvlQlymkBe+DaHuSZFRya1Nqq6aL7wawVwDhZU8s4QJGzi7fjJ0eP/lhNhP32799OU5noqeXwK4V8eJoyBYmZKtBmGhqPbWM9PSRmTQ1hKQjDlszLX6HRLo7fuxn4tRVlG7MRSrqzgDUjLyRkbLU2ZAG3ysDHAk+7FSikDo+axZSzKyDzv5z/y9xNgmW/lgWabc6s4Lqt8ejbZcZjkkKC8mz4on+syzcva2PpYpEyy4vtJjSSmLUsNBWpWes7RL3vpSq1ATxSRJEt7Pm7LAHJOU1A+w3RoJAR0QDkw0koO7GE8LFksxPB7B60kYNisilFlkVd6liiemSR2jCzDqJk4HlkbTf/SgGkVvLJ6BWESssCdiKu3AcnpnXROqzKoh5RDauCjPwwJ1Fro/r90oXcgMoacPuCoUOmPEAreO0XKGxlUlhC3y3kA0eMkYZyFJEtMTcxaFfFgyYeNPGg+d0eNLdyCL9HexhEVRP5Q+QPkT/8zvjDfcQ2uMmZA6hra+rWRXvTl2BvGhTRmyoHS+9jut6xLPuKiStSH7QDJd5mNAANJU1YjwWhFi4Lrb9AGivg1ErmHxpXI2H30ZxN8ZYKRAL21zhc1OjpH9bUgKR6jF8cTsilrO45nKLljEuUj0ihnY419/amOY7j1DMs/+H0ck4yMGvZNvY/2/2xByKZGduksXdFcunKuiuMRnDLh8Hu1/JqQheLjJn6hZwlWrong/dawbKBgS/okUzCshiqVmDI+3evcLlK1TdQgT1lRrb5gglX45YkLBTT5MP7d2fkErLcfjF2LMpAeieXevb0j98d4qpPiD0ucgXjXMnEsgexChdgnkr+YT4i82/nI+SF88M5KaUM7W7Y5hbXOWFOPLiCbXm1Z3GVAm817LmGxFm7gXM4OnyoXUCNpgKDxXtaOKSmLgFi8T1IcGRlxhSWTEBKFlvy4d33J+TouyfPqjXYbDbVCqhlYv/ZFhNzYw4nnpssvHCFO9FRxt4mwBJVC3lf1MX8x8vL80CH5WFmBqh3Txgo4A3w3e8eIRknFwG0h6Bdvjt3ytN/+tOfyvP8yWEQLvFSWaO+IOyR4yQpt3iW0gtBswVbFbLQfEvSxhJryKgwLNHhoHL78MLKXXi+vPMQ6hYNUUERNqo1WwmrmOip/XYcUGr/nNxYNA4f4gy8SNaQ0e5a6FBeLUdZ1F2ROqO2+tYOqb86eOTCSjNdUGmaMidnzZiBrHloV5Vnvq59fG9J1YZgBzueZ8r5TC4Rth7gsbIJMudvl7fKGbpYjN1qeM6N854V2hCU8lDgXVEmtBP+6u0/Uw5o4ya2t+CGlU3cxHaHuEmB2n0mnZ71QDgO0R2eFkg4TZJrlj+k79cwZDmI1CmlLdAaFb+GX9pS0RVePSrQkhde+K5ADPXv6tV9txGuGam6mexncrs8hg1wFuQmO4bKctbdKCvOXWu3W+W1lacGZLOuWHaXVmDl1EQKAzdmDCKR6MmFe3wPVrwFE1RtZ2HcBvSu7rSq6tMO0AuoA7cTD14X3LC8ULnUQEpDxWvKODm9MSCscq/Jt6/PXp8eknOqDHkr4LkV8TNq7OJV34DWdAXkhUwZ6DvFoKPvnjw93JM415HFzd1i+CfPz+VGPidIfsSCda+ZeHa482vJIaYhZNPw7X4/6NkgYPhkdpUNiKSAHZ/MVfsdc5nB+2xq1jNtqDItXxezvvClLdqThOY53zol3MFK0EYLznVHJKC/Ie/fnekRwY6xyv6uKe9ord7T4ZNTYzfDLK8+baFqq8/rtX33x9iKVJ3sC/oBqIfB3fX+vFXncQrLRVfzaVVE/SfqP1H/ifpP1H+i/hP1n6j/RP0n6j9R/4n6zxeg/wzyKmZ4i1n5ku70OeXGVu+cfaCHQ28US8unO5T0OQxqIzOMdZTeVwI0HqU59fHLlVMJaXzBNKFcS3Il5EYQqivv9t0dtzRNFWg9y6UyFsNeda7doqHO2cp+svYfoCecEtSrdLnUhnLiv5yQ1zTXdpN/OHYlPznexaQIQevV2bFiZl0sJonMpispVxzYoz+JKWcL3xsTeWGmG3bFpoO9Hbog4cvXr8jTySPy4bgwcsk4t0LBUqoMRQUluX6O800LI0vXCmqMYovCQPMGdfMYj7LLd3iaPX001ZCg14Se2II/0GoILB6HIcZmDeP6CONyhMPdrbGfiuFos7DEfZFm3bruSgspxuVq17R3/20Zc1c5IcoMDMtAEwGQQuocF+0cMMvjR0QxfTWyuqTEiFWdgKCKSU02a1BAlkzAeKUoE+UYTDg3FSZF6aLpe5+QN9JU5IgnRSKzTAp7YCi7E5VxHr0yB0F8BDZ5B2khUipM+ARHBp4Gh7WFmlaukXBD7RqOyLy9YyahgDMBs0fo0VLoAp09qXfEoSHwf96a8Ik2CsDMnLPlfETmoYBmEJxnfJGV2OZ7EMULxq0MjSA0BfFWTUt4IbY4JVy6DAKeIMooec/gFGRMw4S8L6codIvfW6oInqeWaDh3XhR28kJDHXx//DI3v3O+SeV6tZMAnCh6DYL8KAsN3dj//cjqKXB2DWo706CuWQItq0Gnsi/O1TUivtGEnEsrCC6XLAGykDcjsqArPyO41fJavZ2wPaFaI+eme0ejvCcZCNY7SMlfrNQ7f6kKtZ0TJvyf5BUVn78hPhIPnNBeTELNMC6OPPcKb0crbJYPwuq0w8ZGstumgBFZyILDNVXpiChJUyQu7yS8odt9oVcsZoEdNPFrVvSYspjSZuzSG4AwzGzJArjcEOr5V8mOpCp5WS8rsxpXDzvTTKw4VN1YXmVPso9gZhNyQoU94ShZcmpGmBNnOyJLLqWy0y4znHZqj7a9Bjw2z7peUaKsGph7K9GXCVFKObFBatUB4MixVT1/9MfHpM4CSEAOJQ1UlEEYtfU2rSB44E8rexDMuWGlU8tYrLhmZQ0Lz7LglfC6H1JuzNvR8JQeDSRNSqRI7zGnumAGGkSzX4bUwOXxMJqPe9F0klwPliPClqUg2ORXgZc56btMdPJC0V8YHxEXioKbG25MFco1F3CD+VT+RnlGlZm7rUY4FWlG1ZU9gKggZyJlVOydVjImZlQB7Wy+RkV3AtdstQa7+eAa3BVVyq4ZhnV45lTYHRM8VRsyLMZ9oOCOyYxwPs4u3o4fP3r2bHwUYo5sX5NgNF16iYPyUlRpb+KT4zluSCENmZ9QzpZSCUbnPiEW5lYrobojO9b7v07IsWu9vT2s6v2FbYl43N7whAqaUts4oH97+7/QnArXHJaQmELd8cHFhplfQFmysp9dUWGk2ENiqI+isqMhKjvqkf8TZrYjYuRGIIlcM87pCibkInO5w8yaCqsBlZ0gMc4ezfe/ex4P4fW4By+7W6wkwBE/XSwKtRgRAWy1Xki1ltIJQSmzAyfmToSP5vdM+uZY1YRc+CEXlCklcbD66LfTGTIq7KNEogVtJWo39Gzmwroo39CtJvSaMo4a9qIwLu6itz+SBNHF6Sd2KohF/rdG2k+GSOBJvxWksdwblH8/ZtEfz23zuZVPw7TdlwycuQ2ZqZbKWKHSqqzIZH8oQAkNTtTJqNiS7xWIZE0MKMWMVAx0dbb5uh8KjAq4lWycvBYMMZASxMhiSw27BneQaHt4nKyZ+G2srj8uekKhmxV9kdAb2YyDJni6PbpfALTr/vb4Z9fGEoGCFStZ/WeGaYZuK4JQQA15oRjKtEx3DCA/vOhPrGj3ervt+7/2tLWiAcYXI15G5mMnVKQys0NaPhIs39QEAK2G5CPDTo7mXbCRiMhGKp5umC+zghtVyHMK4Y2qHFKSK5YA+fbk/fmhDyqyrFFckQR3JQr9Smo9Xjg1rxaxv5Ng1E+OSnebuEuezfI+WztufhdpXQpodjJ/YbmbQyta/Vywa8qtOkguy3hzVVeN3LRbkvRKZ61n4pIA1nvB2+Fak8ouDmKyYVcsB3u2SLVyVvnzCo/DvamkC6bMepZS0zJW1ov77BxUpGPKpXDh3A8UxX0pK6sB0TlgBgkOK8rdRaaup5BIfaZQBH1EtrIgei0LnmLsLcZSu3UTklCtZcIwZg5BtNuNZTD+xSNEJ+RvaxBwDSiIa7awQneI4UXsqUrJPA2JFefe5nO5Zrov+LsM865unzn3Ad5Nyf57WKiCqi15/Ii4C1uWBg6ztocX0+HSC7P0caA52QJV+9KiIKOsGfuHJbPbrrsat1zsF0gJflPqf5/NzN/nVud89qQWJ4uXKZRzuYGULGAplaPJo6dPh1q55J19iXf/ucvJNVuJCflRbiyVjPCrFQhQTu1LEsgteWX0hmVFRjiIlVmHXKEN7O2KHj190gnxDVff16DCQUiN/boQOEnpfaEkcMO02VMmgTfOJt32KWlbsAdN1+46Yunvc5XZPvydDeWOOmG2LDjvWtv765ugvzw9f3d6cnx5+jIsnjLbbzQpv22bJheFZsKuvi0fEcGSK/cXUsjWX+7hbDhJgArLPxZAdM6ZcQlK0CQ4IpzqYOx/VyW78Omn3QUe07Ux98Qp+mdzeA7/1gNyDkpLMaqKv9HOzLjHW5gVuwbRRaRR/GmYYBe45H4l94hVxtKUQxetZvmn4eX68CRpRVf01TDSpacnGbrMcai3060M4Dm1/H2bscTND7X74Rs9avS9n5nKFSzZTcsNyBf1Z7VnNyMnUxh7pHsvrTA5+7w/LJZtyMuiHqkOq0q3m18FXtW96yzLPo0W/feOiDLGt54sjzvuQ/dlo26UWwnbD9om6qxJ1JkMRO3b703sR0+pdlr6WmGXONwrFD6vzdnLmiZFSUb1FaRWUNG1Jxr8FzRBvSlcS2HG9eDWYiXq4JzofU0YePGn/Z2Vq3GEBd8SEInaooCFuebQPVAxMFZwvraoCnQ9fkE1PD5y9niXMwN9nEPWDF3wXWf8yNdSwMziFG6J2zPfaVBbAFvXz1RsTd2+uDup6NwP2gtnz419q2II1uA8wQRhRlvxRQqrVLc83j6cTh49e+Jb222CKbfbKiOm4jDFhAkzVZBML8fvTk/G+OkUxOfmPvtwf9MYRUe1TzCRlSYb14OzGXx7cnK4pxny5i7Ma5QGbcRv1JOT8mGSclS/69Bj2sudK3xHwJtoHz0lKVsx4zdr+7tECm11DjsErWpT0Cb4c7kZePPyxDkd6mLhEraUHkzfXrzZl/s/BEf9PoLvqeyub9lov/fCYWb74O7W9WlbjXX7DRDj4Eb5fdDo56QAR8bbf2gMuyQ5bozWqV0LF4bezOyR1BedW9bUI3PLwh4XBXpTSyMY3Lzv7/RNXkizJnMcI3VX4/6H8/xsZIJ8eJOCG7qLfnqrH/w32s/DhFwUeS6V8XKSaQhg6Izh84FJwbc1g7UTff1kMk0eParburh0ftyECcxzWlDu3O0fPeltFuwFHxl08ckW/tqC9UzdMI135i/EZ33MJO48f+p5oZI11UDeC9YXYOKrZ4VgphVk0q4aDnQKTQk2nZBTmqybhQS0oQvO9BpcHkBh7EKXT5TRan/hLSjYb4Xp7armw+ffS6LOGoN5m5VhlPu3j9BmZRqbFwV/DGcoO10qmfksi37UnaW+dPmnnaC9UECvUrnpSR061Kxm/cMW/UxLmhJhn+/a3QyJMp0sKTt1U1JmgfUu7NUNhik7ZAYy39/IF1myDiV6zfIcU0auqUi5Tx6pC+XCA+wipkzjOeocvKjYtp3yz5bugiSHhC23ZO76npTAzh0j8UjBz8gp5hawGQI0JzkvtGOxjYIAXPgdQAy/S0DnJGOi/sUsAB1qwu827JcVYHj0ozk1l5rhzXrdjZ0zbTc/xgMGTlBLAY0zFbIzK0jQCcslY67xinenF5fk+Pws3AVTslaw/PO/HnxUfuZ/PfCOUY0kz94iT3fjP98h/rvpvp/k66Vdqq8oOjgTOuIhL8qKNpVXRP5gBP7QrzOFEZvRBlVhTIcf0+HHdPhf23MZgUE101BXhZErRK4QucLXxhVKYaX9LmVZGvlC5AuRL3x1fKHUnzs5ucriyBkiZ4ic4WvjDMHk0fR8qQojV4hcIXKFr5UrzHqNj321kU9EPhH5xFf3aG+4hevcmketIvKFyBe+4sd6456JeybumY9xs3QOS23vvXppl0aOz8/QYRXU2Ls+pOgRrATl6M733ocfKEikSBhvfIIvMLhg5FqsvXMl8k4ojSB8cpznQBWmj6hVOBdVMMana1KQS2X03rIy1h9oridkrJf3+KcGX7Baw8lv6XFrtwJjF9trF8k/PWrqwBeCGR/9ffaS0Gp9FtI/8Ixuqt/oxoKtGaamKz2bMSxYV75zLthGQQLsGvSEnIkyg+zI5fN2Xp5Vdpl7UYQbILjcOT+oihzR+dvFutfptUmBl9XgUvBtDQIMmKLCe8UxTTS9ds/0Bo/udtTy9dEUM8rJwkzxKz1l6dR+9mtlGGXiWrIE2jygUfyRTMB/WxGPnbkHeCy9P4f+R7wDUnqWYoseP85A8/ohvTcHmTM1sJJq2+TNVWFP6gEDGQktducH/3AM0bnM2RPaQr5/rnj/UH0EMMRW7i7J/N0g/lxQzD3aALNWOABqaOEzV6Lf6GYtOew5uexV0bTj4e++JCsyuSJXALnlmuh//e3FX98flqfPAzzZM2xgaJsWolEhKkhRQfoKjY2WEc3KoIiKQJrlkTdE3hB5w+/Y4Gh1U+hPLAGdrBJDT6k5tQGf/wlark8kLlKnly4LvmSc6/ZDQOW3gzGh++APnIEwHVNRrbTP3rHgLGkYESywY8wH4pEaJxjGnBKa51brN0qmReIsSD6SCRX0xKphFaN8oSgTlwpcvjVPFnUz0sg/EYMjknkjb5tLsBogwCDakMI26PYxwVxMMPfrJ5gbzGdVkW7r+c56eUxs86mJbSzPmKVM55xu+19D62vSiJWz5bOUGnr7cVBPc3NvZl8axX22rVrcMQnmxVHDijnyuwRPntxoF1nYY5/dw6tRioq058moevHtqRKrsO17zUMQo3+V+WhR1kACopB8YBayItWf0mpVfXFJiD5N3IhZiGIWopiFKGYh+jWzEHWl85Ibh6oonn914nnHNpChCiy0UUXir7q60mJPo4bdoKe+fV+5rb+pGqSa2ifOpOIldvenMsLuOy8X6Qk5FRYsTZZATaG8FSZ37bR/GkRdgXE2mkrfToHTLWAyikWhtLtjd4+m1d+qo5Y9GXw+d+kFVW6XMy2UeygvteBYllEaomhuAUkDQhrfSnHNfR12XJi1VLidQsOHF0LqyM6ytgTSV9vzkh2ad0rD2hp4SqQgC1hTvuxItDvWY/xazJa95qtabSsnU6tm+OLcqmmysORkiSWRWcbwEQA9Iobl2j18Ix031Lu7Mh8w1/dY6qORPhrpo5H+93+B5+wxC6oHbTW+7j7G+pDJKVito/E+Gu+j8T5qB9F4/5s13v+9nZDUi2UnpXoyqJXpPlVMD9gU68pOaOrev2hYl92x2Uwoyipf4fYDxF3lZtRVjJyNWgGeOTvMn+gHp/2T1KhuTlWnalhP6MGwb47wVdzGpCVUkDW9BvILKOnekbBs6k5tMCoXUbmIykVULnaiXDQY3Uwbago980rCHRyz27rmDN2uGtZEQvbZDt8jrpOH5w4KqG5ZLcuiLtyuimzW2zbcDl4rEMzPT9+8PHvzw3xvLwE5bQUfsWzyt0Z5zyrU3/h8oPc/LyCRqEvWcvdbTsKhttGJrrUKabd38zxwz0OeZWbjVcFSPJIWhame91Twb5AYfNyTCfd2p3vk81eVruEmZ45FdNe5WxfX+kte688Pauwy1C8/7M4ft63Qu3og7S4DNXc7Xa+YuCIvG1FjrYnjTFw1j9FQMqx9KOC48B9+PL48fXt8QfCTIFXQnE0VLMGKEGB/jRXoXAoNevqHNTUgqR7jF4cPH/QHIum+CQIiuRx6DySDlFGM9bMr60RPtL4tMmZKOQy0cW8974e61wqWzTTRrqBPo7YqsAFiqFqBIe/fvcK3sDN6FWwEbu0s2Y+CC4O3yuKDJsF6ocmH9+/OyCVkuf1i7NizgfRODv3s6R+/O0SacHp5rsBur8SyRpePP+GFN1nM/2E+IvNv504Znx/OO8aqucV1Hp5dv4ItCVRncZUCXdHsZkKSwldK3BQ4HMN767pYaLtwwmDxvh5KtdTUJUAsvgcJjtxV8RK9TBZb8uHd9yfk6Lsnz1qeKmEF1DKx/2yLibkxhxO/9xde1bNT5CljbxNgiaqFvC/qYv7j5eV5oMPyIDcD1LsnDBTwlpTe76fyAScXAbRs3y7fnTvl6T/96U+lLPPkMKi6GtQ1aLReiHC6Ur94ltILQbMFWxWy0Hzrw3zDEmvIqDAsKXUctw8vrBaIp8E7D6Fu0RAVFGGjWrOVQBvQ1H47Dii1f05uLBqHD3FiXSRryGhP+Gsoryl9oahPaaoYNcEnXXZG/dXBIxdWkuvRWkvXklk3gr6qPBuIpW/4pmAHO55nyvlMLmf9Mf+usvWQOX+7vFUq0MVi7FbDc26cd/RtQwkXhf0VZUI7wbfe/jPlgDZuYnsLbljZxE1sd4ibFFAaVh8OxyG6w9OCdY3LzfImprulrGHIchCpM5G1QGtUPCRsg8/NK7pCvyMFWvKi41AW6t/Vq3uck3wzUnUz2c/kfkSWjgcI/becdTeqBbbY8VZ5beWpAdmsK5bdpRU4Jz1h4MaM8e6NiRXBPb6HO4UFE1RtZ2Hcpi8t1p1WVX3agTAgunA78eA1vkBeqFxqIKWR5jVlnJwG53BNvn199vr0EH0hyVsBz62In1G8nKy+Aa3pCsgLmTLQd4pBR989ebovR/nuA5F3i+GfPD+XG/mcIPkRC9a9ZuLZ4c7tt0NMQ8jm/Zv7/aBng4Dhk9lVNiCSAnZ8Mlftd8xlhp/LN+uZNlSZ1r24WV/40hbtSULznG+dEu5gDRFZFg0qEtDfkPfvzvSIYMdYZX/XlHe8O9vT4eP9SWZ59WkLVVt9Xq/t8Y/yTilVJ/uCfgDqYXB3vT9v1XmcwnLR1XxaFVH/ifpP1H+i/hP1n6j/RP0n6j9R/4n6T9R/ov7zBeg/g7yKmVYimFDSnT6n3OwskWwDPOAclF1dM+T63tekdkfVU9uDAVwDRz/4sh2RyyUoSNvXwD4Q4QL7JedV+6VU5HVIzt284MvpNqd8kshsWujpBhY0z/U0y/OphqRQzGynDs5xNf7hXmKC88LAzKdZ7sjGfdXD3DCRwmmNtRDhRF7jHAYfpZpzzp5YoPPR7PFV7eByJlJmUdVkswazhg7EhGkCnK3YgqPHHHFrVqMZ53NRy4PkXYC/GJq5N3u4/7S6lMjoKPure6oVedrrNNssj46Uv11Hyjpt+qiivmzzWKFb2ebLwlt4WCeDw2dE9nQ6i3E9Ma4nxvXEuJ6HiOvxzObOiJ7Bdp8Ty9PmdF9GJM8A1I14HgzQf3n65uz0ZYztiWLKDp+Z+cLzMS2k5EB71HErO/BZJZvVLjJaNXepX1tZoGSFHsi1K8kgyZW2tQGdglyAIUaSuWWfc8KW2GMqkSpc5gBbHTJzdROS9Y/gE9yGznGqyt4/t9svJdiozTtjqFEMNYqhRjHUKIYaxVCjGGoUQ41iqFF0tYuudtHVLrraRVe76GoXXe2iq110tYuudtHVLoYaxVCjqP9E/SfqP1H/ifpP1H+i/hP1n6j/RP0n6j8x1CiGGsVQoxhq9NWGGgXgyDt0krITS14ooFep3AzvRVU2ni1qjTu7cqDdkGuz3YGh2ZCX8+52DdxYzFcwU9RAXx74ZnU9C3yzpu9padeC2BZut6RgQGVMeFcCH/lhpN1W16AMWSqZoRRRur0bSaiQSKmfFNrwSTxDy0IlMAsDNle1U/cFBnx8hniP5r3+qenWfVVT8zHBMN57rgqEwq0wIac/F+yacnDbwu4EDPPyfMDRXoWXVw2NO8BDrIxUZSgJAuCEVtuXkdXj4kHiVRiJ4wcoQ1AkE2b3fLY/dmylpNazngiyVkWMI4txZDGO7HcbRzbAHQSYPt7QKI6cIXKGyBm+Ns7glEf/LH/j7dGqOHKGyBkiZ/j9PljPqVlKlfnd3mYQtdqW7blVM2zwCy3dpldGWIIA0BjalDGMA3ZvFy+UvAJFV4D1fr20lgnDiBJ/c3CnMSfm5oj8MfLHyB93wx/pFmC2oBp6xaeqriE+DUhOIfVGuOcI8f1ks5ZlfDHWuPQAloEsC75knLtiH9h8Wf+WaUK5luRKyI2wbCSELO+Db3AGwrRDuuulPbeoxYKzpB6QjsCO0SPNIzV26TJSQvN8Qs6EUTItEhdpqIs8l8qQQtuTQNuDJDDQF4oycakASI1c3Lnh7lbsBgXlRyRzDPSe0TRVoLXLFxIgmLEUI1rtvqPXlHGL9Z7MoAhW866gDmjvrDJ09qCOKWAqBfyG+G8+P4HH+9xO/rMntehfZBaUc7mBlCxgiU/ii5QcPX061Ioujb8xc2PYXesG+Gc/aFVCNFuJCflRbuAa1Ai/cgkNLAukSQK5JZGM3rCsyAgHsTJrx1hEE3u7kEdPn3QCl8OF/jWocMZYFihIIXCS0vtCSeCGafMrpyWpkW7LZ6xePpQrwmc5OHsZDjHLV0hG9RWkdoK0u+zGVfBf0CRB4cYzeZc/w1/j2t0ZXD1UioIfAz/t7e80UYAjLPiWgEjUFhcWxSd0tlAMDFVbcm0RFmhrf0E1PD6y3xba8QX0GAsxyLrgu7K+30OPrl1Q9oiKfbVRaoxSY5Qaf2dS44MlX30gJ4aYefUrzLyqwOoWfWcY6hytkyuU3ZZpyOkqn5Fs1XcRzTjxQI4HcjyQH8KME9N1fr3pOj8/Y6I7oGKexJgnMeZJjHkSY57EmCcx5kmMeRJjnsSYJyTmCYl5QmKekJgnJOYJiXlCYp6QmCck5gmJeUJinsSYJzHqP1H/ifpP1H+i/hP1n6j/RP0n6j9R/4n6T8yT+GvnSRwAT0gDMyNn6MHRZiSNmsGXmVu+Ml+GU4kD9s6Ht4eafc67267PL+O1bQ/r2gcXNl/Y/v747NXpy/mOMBlOLXhOt/fMK5i7lrcnFexr1J2ITiLB3biCfYgZvaLbcnRbjm7LMaNX5AyRM0TO8NGcodrrlQQzoIz3NR3gG7dIQ3VNvZKKkLyqhBYCTJmI9R2YQgkMWQDR2CUtEZhpkjLMoi58/uK+xq2Yc5fHocweQdaSp7gXmSL7iSbzGZch7WPFPZWRIUeGHBny75YhxzzwMQ98zAMf88D/mnngg02rRyDpVEVxJIojURz5HWegiTmfI2+IvCHyhi8q5/OtGRdiRqDIBCMTjEwwJnaOiZ1jYueY2Dkmdo6JnR82sbORhvKZE0b7L/qGWkTpMUqPUXqMCZ4/JcFzzOscc19+whk27PrtMxi25YdWxUcmlazL+c2szwFwrM8w1Iq3GmnnFbSVhQvwcTRXqULErJUsVmsyPz++PPlxPiFnS2wtXe7CEBZThg24rxIpDGVCEyn4Fi/qGqOOgoCjweh6L0aSeQpLWnAz3/XuW7M8Z2LlYwN6GEanQY1z+Lp+3uErg/a5O3nAS9czq45ZSHtj4tstGjHxg+pM+KCp15BcakMrpYa8pjneq344diU/uQAwJsVrMDSlhlZcZcXMulhMEplNV1KuOLBHfxJTzha+Nybywkw37IpNB3s7REL68fL1K/J08oh8OC6MtNq5nV40ZFrKUpLr587fojCyzE9JjVFsURhopqHbPEYmd/kO+dzTR1MNCaae1BNb8AdaDYHF4zDE2KxhXB9hXI5wuLs19lNBXg4FvYQl7gt36dZ1V1pIMS5Xu5YCIahuwWZSyRcyA3tsaCIAgrqBc8Asux0RxfQVGo2dF4tOQFDFpPa6/5IJGK8UZaJSD4U7giz/DtKX731C3khTkSOqNInMMilqmo0T1mUOwnsMWOaWFiJF2477BEcGnpaquJpWUg/cULuGIzJv75hJKOBMwOzR3Gk8hVOBfTZTB7hcVl+Hra6NAjAzJ0fNR2QeCmgGIQOpLzLbHOZ7iGcuGE8tG7MgNKOZWzWtawNii1PCZeKSMTqCUGAPXhDGm70UZEzDhLwvpyh0i99bqghCpSUazp04gd6qvqEOCVT9Mje/cwley/Vq2wdOFL0GQX6UhYaOqWBPAlsKnF2D2s40qGuWQCv1Qqeyz07pGhHfaELOpbZq95JZeUbejMiCrvyM4FbLa/V2wvaEao2cW6J0vbxPnrb1DlLyFytZzF+qQm3nVkx1f5JXVMB8z3jghPZiEmqGcXHkuVd4O6H1zfJBWF2IfWMj2W1jVeCFLDhcU5WOiJI0ReLy0vWG7suxTBeLWWAHTfyaFT35QJjSZuykTBCGmS1ZAJcbQj3/KtmRVCUv62VluliMe9iZZmLFoerG8ip7kn0EM5uQEyrsCUfJklMzIhhZOyJLLqWy0y4znHZqj7adPSB0HxWkedb1ihJl1cDcE9sgKMqlnNggteoAcOTYqp4/+uNjUmcBTUUFsw2AMD4WuRI88KeVPUiyhuTKSqeWsXhdw9/q8Ep43Q8pN+btaHhKj/r3K2rO95hTXTADDaLZL0Nq4PJ4GM3H/c6hKMn1YDkibFkKgk1+FXiZk74RY0seLxT9hfERcVYm3NxwYyor7VzADbqa/o3yjCozd1uNcCrSjKorewBRQc5EyqjYO61kTMyoAtrZfI2K7gSu2WoNdvPBNbg8Xym7ZmgP8cypsDumdrVQybBoMkDBXRtqAOfj7OLt+PGjZ8/GR8GcaPsK7rc40V4VDKJKexOfHM9xQwppyPyEcraUSjA6n5CfnK11sa2gYvpWW+v7v07IsWu9vd1i+v7CtkQ8bm94QgVNKb585dG/vf1faE6Faw5LSND8d+sHFxtmfgFlycp+dkWFkeIO++veqexoiMqOeuT/hJntiBi5EUgi14xzuoIJucjQ9GQPUWE1oLITJMbZo/n+d8/jIbwe9+Bld4uVBDjip4tFoRYjIoCt1gup1lI6IShlduDE3InwUaDxu8jasaoJufBDLihTSuJg9dFvpzNkVNhHiUQL2krUbujZ4W6db+hWV1fsaC2ljUmp94dPw6Ho4vQTOxXEIv9bI+0nQyTwpN8K0ljuDcq/H7Poj533gpVPw7TdlwycuQ2ZqZbKWKESL1Itk/2hACU0OFEno2JLvlcgkjUxoBQzUrG6+4Wv+6HApxVuJRsnrwVDDKQEMbLYUsOuwR0kmBXmZM3Eb2N1/XHRc8vZrOi75NzI5hUnwdPt0f3uNl33t19tujaWCBSsWMnqP/N+I3RbEYQCasgLxVCmZbpjAPnhRddDIpzD7bbv/9rT1l/oe4nZyHzshIpUZnZIy0eCAxU1AUCrIfnndU6O5l2wkYjIRiqebpgvs4IbVchzCuGNqhxSkiuWAPn25P35oX+ZxbJGcUUS3JUo9Cup9XjhryCqy/id3OJ88oWz28Rd8myW99nacfO7S9RSQLOT+QvL3Rxa0aoMlJqQy/IqWdVVIzftliS90lnrmXi3nFovmGKv1qSyi4OYbNgVy8GeLVKtnFX+vMJj9xnz3jhTUTsmvm1YGrQoOSvh0vuzKbOHoEnK3dUIzKxe2TWC9dc3QX95ev7u9OT48vRl8IhSZvuNJuW3bYvBotBMgNZYPiKCJVfuL1zfrbe542y4DUqF3foLIDrnzDiXANTUR4RTHWxw76rLW58FwNnV0QkpjLknQa5/Nofn8G89IOegtBSjqvgb7bT/PRpHV+waRBeRRvGnYYJd4JL7ldwjVhlLUw5dtJrln4aX68OTpD1R0LHWSLSQQXVHXWun/eNuVmxyXdkzdJuxxM0PtfvhGz1q9L2fmbKqIrtppTj0RT2nAFYh0JhUcBTiVcPk7NOsXyzbkJdFPUYqrKp5E/8K8KruFURZ9mm06L93RJQxvvVkedzx9b4vG3Wj3ErYftA2UWdNos5kIGrffvcG4uDsIAce8XTlzdvmquyW5LHBGcI3biaQhLoPOpHLJShdbYOtFfYkdoFXXiy5IkXuk8mE5NsxDil6kkZP0uhJuq+Xye9+tfqYFIL9XAA5e9mhZerY2lgDh8RA2uaPezo/OV203hwNJW1U0up3O/evxsBRR/hr4Dnu1IwkayntgScIzV0sgdVq2ni2bg++VwDkwreZj8j8/cX5BTlXTCpmto2a05v8v/6P81oiuWtAmQJiv3CXO+7j7f/738UN++//FGT53/9J1sV//d/5hLxCW90v4JwMG8jJRipkNOrtWpxZSMmB9ifIRXJoJ8QNhc1VOXNa7/H5WfkADzpOzkuq+jOxFD4fEda95m4uxG3nMdzkkLg8KguUVyuyrUeSqVL42for4WsGG2ccCqNN/PE/D3Ym7/B5sobkShZuLMVAJFbi0ihFVeno3NvehC0J7XQ5r5xLS/z//GnYW5L2+KWFCrJYIgul0dSQBGBrAW4T8ja4tPZA5pR4DXgB2QJvX6JykOw+5lkGfB55sQ2Pk1cLTYWjhxWYuhw22Z/XtJZLMwsbV7Z8dzp1fUnwvXhVNiNSlBFSddsikSE9ojYyQ66QKEiZQcOku3TMnHkORfZGVFyZz2jZGIppcnTUCIt7u0ReNKrvCqcakkKDJoAiRS2679v5+fG/nB+/Iv84P5yQCznyGsP9hveSSa68ofToiIz9R9/60f/xsCpyra+pcq1bEzxj+CLBkvEgD5Qtyf8kjw59YTmYZ1wYm9WCdN7qek7gJgFIW/PlkJXXoJZcbtBsqgqRUANp283zNq9Ptrzzhqa5FEauVhz67O9hMbrOh3fex5SMtr5CXot0s9o34E+nb16//YTRekix3fVfqAD9PZcbUD+wpdHk1auTe45USoKXa/CKdXOH4U6qbZ9bphIxJAGYh/Hq3H3IkLuc2GG2/Rgp9DVECo0OTtyTUSHGI885c26K039z70D8aEz+Gs/kg+cH528vLg9GB+fUrA+eH0yvj6ZBLJkiBerpv+P/M5b+x/Raon5yccXyEoZTlOogvUBKtbrWwfOj7578x//4/wAAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// Voids an order, by ID.
    /// </summary>
    public class OrdersVoidRequest : HttpRequest
    {
        public OrdersVoidRequest(string OrderId) : base("/v2/checkout/orders/{order_id}/void?", HttpMethod.Post, typeof(Order))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        public OrdersVoidRequest PayPalClientMetadataId(string PayPalClientMetadataId) 
        {
            this.Headers.Add("PayPal-Client-Metadata-Id", PayPalClientMetadataId);
            return this;
        }
        
        public OrdersVoidRequest PayPalRequestId(string PayPalRequestId) 
        {
            this.Headers.Add("PayPal-Request-Id", PayPalRequestId);
            return this;
        }
        
        public OrdersVoidRequest Prefer(string Prefer) 
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }
        
        
    }
}
