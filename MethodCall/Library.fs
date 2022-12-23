namespace MethodCall

type ThreeStrings  = {
    first: string
    second: string
    third: string
}

module Methods =
    let DirectCall (first: string) (second: string) =
        first + second

    let CallWithRecord (input: ThreeStrings) =
        input.first + input.second + input.third