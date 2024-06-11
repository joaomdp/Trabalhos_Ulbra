import 'package:flutter/material.dart';
List<String> languages = [
  'Dart',
  'Java',
  'Kotlin',
  'Swift',
  'Objective-C',
  'JavaScript',
  'Python',
  'C#',
  'C++',
  'Ruby',
  'Go',
  'Rust',
  'PHP',
  'TypeScript',
  'CSS'
];
class Languages extends StatefulWidget {
  final String filter;
  const Languages({super.key, required this.filter});

  _filterLanguage() {
    return languages
        .where(
            (element) => element.toLowerCase().contains(filter.toLowerCase()))
        .toList();
  }

  @override
  State<Languages> createState() => _LanguagesState();
}

class _LanguagesState extends State<Languages> {
  List<String> languagesFiltered = [];

  @override
  void didUpdateWidget(Languages oldWidget) {
    if(oldWidget.filter != widget.filter) {
      languagesFiltered = widget._filterLanguage();
    }
    super.didUpdateWidget(oldWidget);
  }

  @override
  void initState() {
    languagesFiltered = widget._filterLanguage();
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return  SizedBox(
      height: MediaQuery.of(context).size.height * 0.7,
      child: ListView.separated(
          itemBuilder: (BuildContext context, int indexLanguages) {
            return ListTile(leading: const Icon(Icons.rocket_launch_outlined),
            title: Text(languagesFiltered[indexLanguages]));
      },
          separatorBuilder: (BuildContext context, int indexLanguages) {
            return const Divider();
          },
          itemCount: languages.length),
    );
  }
}
