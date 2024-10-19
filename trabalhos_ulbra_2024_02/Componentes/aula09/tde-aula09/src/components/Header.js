function Header({title, sizeList, index}) {
    return (
        <header>
            <h1>{title}</h1>
            <p>({index} of {sizeList})</p>
        </header>
    )
}

export default Header;