function Image({urlImg, alt}) {
    return (
        <img src={urlImg} width={80} height={80} alt={alt}/>
    );
}

export default Image;